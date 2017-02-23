using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Inman.Platform.Data.Repository;
using Inman.Platform.ServiceStub.Thrift;
using Inman.Platform.ServiceStub.Thrift.Data;

namespace Inman.Platform.Service
{
    public class ProductAsyncHandler : ProductService.IAsync
    {
        IRepository<Product> _iRepository;
        IRepository<Goods> _iGoodsRepository;
        IRepository<Design> _iDesignRepository;
        public ProductAsyncHandler(IRepository<Product> iRepository,
            IRepository<Goods> iGoodsRepository,
            IRepository<Design> iDesignRepository)
        {
            _iRepository = iRepository;
            _iGoodsRepository = iGoodsRepository;
            _iDesignRepository = iDesignRepository;
        }
        public Task<Product> GetProductAsync(ProductRequest request, CancellationToken cancellationToken)
        {
            return _iRepository.GetEntityAsync("SELECT * FROM Inman_Goods WHERE Id=@0", request.ProductId);
        }

        public async Task<ProductList> GetProductListAsync(ProductRequest request, CancellationToken cancellationToken)
        {
            DateTime beginTime = DateTime.Now;
            string sql = $"SELECT   Id, ColorID,GoodsId ,PicturePath,Remark FROM Inman_Product Order By Id DESC OFFSET {new Random().Next(1, 10000)} ROWS FETCH NEXT {new Random().Next(10, 50)} ROWS ONLY";
            if (request.ProductId.Count > 0)
                sql = $"{sql} WHERE Id in ({string.Join(",", request.ProductId)})";

            var list = await _iRepository.GetListAsync(sql);

            //var goodsList = await _iGoodsRepository.GetListAsync($"SELECT * FROM Inman_Goods WHERE Id in({string.Join(",", list.Select(d => d.GoodsId))})");

            //var designList = await _iDesignRepository.GetListAsync($"SELECT * FROM Inman_Design WHERE Id in({string.Join(",", goodsList.Select(d => d.DesignID))})");

            //foreach (var goods in goodsList)
            //{
            //    goods.Design = designList.FirstOrDefault(d => d.Id == goods.DesignID);
            //}

            //foreach (var product in list)
            //{
            //    product.Goods = goodsList.FirstOrDefault(d => d.Id == product.GoodsId);
            //    product.ProductSN = product.Goods?.ProductSN;
            //}


            var response = new ProductList();
            response.Products = new Thrift.Collections.THashSet<Product>();
            foreach (var item in list)
            {
                response.Products.Add(item);
            }
           
            DateTime endTime = DateTime.Now;
            response.ExecuteTime = (endTime - beginTime).TotalMilliseconds.ToString();
            return response;
        }
    }
}
