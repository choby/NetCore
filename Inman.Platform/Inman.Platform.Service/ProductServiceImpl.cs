using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Inman.Platform.ServiceStub;
using static Inman.Platform.ServiceStub.ProductService;
using Inman.Platform.ServiceStub.Data;
using Inman.Platform.Data.Entities;
using Inman.Infrastructure.Data;
using Inman.Platform.Service.Dto;
using Inman.Infrastructure.Data.Repositories;
using Inman.Infrastructure.Data.DapperExtensions;

namespace Inman.Platform.Service
{
    public class ProductServiceImpl : ProductServiceBase
    {
        IDapperRepository<Inman_Product,int> _iRepository;
        IDapperRepository<Inman_Goods, int> _iGoodsRepository;
       
        public ProductServiceImpl(IDapperRepository<Inman_Product, int> iRepository,
            IDapperRepository<Inman_Goods, int> iGoodsRepository
           )
        {
            _iRepository = iRepository;
            _iGoodsRepository = iGoodsRepository;
          
        }
        public override async Task<Product> GetProduct(ProductRequest request, ServerCallContext context)
        {
            try
            {
                var product = await _iRepository.GetAsync(request.ProductId.SingleOrDefault());
                var goods = await _iGoodsRepository.GetAsync(product.GoodsId ?? 0);
                var dto = new Product();
                Mapper.Resolve(ProductMapping.FromProduct, product, dto);
                Mapper.Resolve(ProductMapping.FromGoods, goods, dto);
                return dto;
            }
            catch (Exception ex)
            {
                return new Product();
            }
        }
        public override async Task<ProductResponse> GetProductList(ProductRequest request, ServerCallContext context)
        {
            
            DateTime beginTime = DateTime.Now;

            //为goods表生成查询条件
            var goodsPredicate = KendoPredicateFactory.ResolveFilter<Inman_Goods>(request.DemandDescriptor?.Filter);
            //根据先从后主的次序
            //先搜索匹配的goodsid 
            var goodsIds = await _iGoodsRepository.GetIdsAsync(goodsPredicate);



            //为product表生成查询条件
            var predicate = KendoPredicateFactory.ResolveFilter<Inman_Product>(request.DemandDescriptor?.Filter);
            var productPredicate = PredicateHelper.BuildPredicateGroup(GroupOperator.And, predicate,
                PredicateHelper.BuildFieldPredicate<Inman_Product>("GoodsId", goodsIds, Operator.Eq));


            //查找product
                var productList = await _iRepository.GetListPagedAsync(productPredicate, request.Page - 1, request.PageSize, "Id", false);
            
            
            
            //查找product结果中需要填充的goods实体
                var goodsid = productList.Select(d => d.GoodsId).ToList();
                var pg = PredicateHelper.BuildPredicateGroup(GroupOperator.And,
                PredicateHelper.BuildFieldPredicate<Inman_Goods>("Id", goodsid, Operator.Eq),
                PredicateHelper.BuildFieldPredicate<Inman_Goods>("Deleted", false, Operator.Eq));
                var goodsList = await _iGoodsRepository.GetListAsync(pg);



                var list = new List<Product>();
                foreach (var product in productList)
                {
                    var goods = goodsList.FirstOrDefault(d => d.Id == product.GoodsId);
                    var dto = new Product();
                    Mapper.Resolve(ProductMapping.FromProduct, product, dto);
                    Mapper.Resolve(ProductMapping.FromGoods, goods, dto);
                    list.Add(dto);
                }


                var response = new ProductResponse();
                response.Products.AddRange(list);
                response.Total = await _iRepository.CountAsync(productPredicate);
                DateTime endTime = DateTime.Now;
                response.ExecuteTime = (endTime - beginTime).TotalMilliseconds.ToString();
                return response;
            
            
        }
        

        public override async Task<UpdateResult> UpdateProduct(ProductUpdate request, ServerCallContext context)
        {
            
            //var sql = "UPDATE [Inman_Goods] SET [DesignID] = @DesignID ,[ProductSN] = @ProductSN  ,[ProductCategory1] = @ProductCategory1   ,[ProductCategory2] = @ProductCategory2   ,[ProductCategory3] = @ProductCategory3 ,[ProductCategory3ID] = @ProductCategory3ID ,[Brand] = @Brand ,[ProductName] = @ProductName  ,[ProductYear] = @ProductYear ,[Season] = @Season ,[ExecStandard] = @ExecStandard   ,[SafetyCass] = @SafetyCass  ,[Component] = @Component  ,[DevCost] = @DevCost ,[FOBCost] = @FOBCost   ,[ProcessingCost] = @ProcessingCost ,[ProductCost] = @ProductCost ,[InternalPrice] = @InternalPrice ,[SalesPrice] = @SalesPrice ,[TagPrice] = @TagPrice,[BatchPrice] = @BatchPrice ,[RADCost] = @RADCost ,[IsEmergency] = @IsEmergency ,[ProductTitle] = @ProductTitle ,[QualityGrade] = @QualityGrade ,[Filler] = @Filler ,[FillFeatherPercent] = @FillFeatherPercent ,[WashingMethodPictureCode] = @WashingMethodPictureCode ,[FirstOnsaleShelveDate] = @FirstOnsaleShelveDate ,[SortCode] = @SortCode ,[ModifiedOn] = @ModifiedOn ,[Sex] = @Sex ,[CategoryClass] = @CategoryClass WHERE Id = @Id";
            UpdateResult result = new UpdateResult();
            try
            {
                var modifyDate = DateTime.Now;
                var product = await _iRepository.GetAsync(request.Product.Id);

                Mapper.Resolve(ProductMapping.ToProduct, request.Product, product);

                product.ModifiedOn = modifyDate;

                var goods = await _iGoodsRepository.GetAsync(product.GoodsId.Value);
                Mapper.Resolve(ProductMapping.ToGoods, request.Product, goods);

                _iRepository.Update(product);
                _iGoodsRepository.Update(goods);
                result.Success = true;

            }
            catch (Exception ex)
            {
                result.Success = false;
            }
                return result;
            
        }

        public override async Task<UpdateResult> AddProduct(ProductUpdate request, ServerCallContext context)
        {
            UpdateResult result = new UpdateResult();
            try
            {
                var modifyDate = DateTime.Now;
                var product = new Inman_Product();

                Mapper.Resolve(ProductMapping.ToProduct, request.Product, product);
                
                product.CreatedCustomerId = 0;
                product.CreatedBy = "测试程序";
                product.ModifiedCustomerId = 0;
                product.ModifiedBy = "测试程序";

                var goods = new Inman_Goods();
                Mapper.Resolve(ProductMapping.ToGoods, request.Product, goods);
              
                goods.CreatedCustomerId = 0;
                goods.CreatedBy = "测试程序";
                goods.ModifiedCustomerId = 0;
                goods.ModifiedBy = "测试程序";
                await _iGoodsRepository.InsertAsync(goods);

                product.GoodsId = goods.Id;
                await _iRepository.InsertAsync(product);
                
                result.Success = true;

            }
            catch (Exception ex)
            {
                result.Success = false;
            }
            return result;
        }

        public override Task<DeleteResult> DeleteProduct(ProductDelete request, ServerCallContext context)
        {
            DeleteResult result = new DeleteResult();
            try
            {
                _iRepository.DeleteAsync(request.Id);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
            }
            return Task.FromResult(result);
        }
    }
}
