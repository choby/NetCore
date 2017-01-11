using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Inman.Platform.ServiceStub;
using Inman.Platform.Data.Repository;
using static Inman.Platform.ServiceStub.ProductService;
using Inman.Platform.ServiceStub.Data;

namespace Inman.Platform.Service
{
    public class ProductServiceImpl : ProductServiceBase
    {
        IRepository<Product> _iRepository;
        IRepository<Goods> _iGoodsRepository;
        IRepository<Design> _iDesignRepository;
        public ProductServiceImpl(IRepository<Product> iRepository,
            IRepository<Goods> iGoodsRepository,
            IRepository<Design> iDesignRepository)
        {
            _iRepository = iRepository;
            _iGoodsRepository = iGoodsRepository;
            _iDesignRepository = iDesignRepository;
        }
        public override Task<Product> GetProduct(ProductRequest request, ServerCallContext context)
        {
            return _iRepository.GetEntityAsync("SELECT * FROM Inman_Product WHERE Id=@0", request.ProductId);
        }
        public override async Task<ProductResponse> GetProductList(ProductRequest request, ServerCallContext context)
        {
            string sql = "SELECT TOP 15 Id, ColorID,GoodsId ,PicturePath,Remark FROM Inman_Product";
            if (request.ProductId.Count > 0)
                sql = $"{sql} WHERE Id in ({string.Join(",", request.ProductId)})";

            var list = await _iRepository.GetListAsync(sql);

            var goodsList = await _iGoodsRepository.GetListAsync($"SELECT * FROM Inman_Goods WHERE Id in({string.Join(",", list.Select(d => d.GoodsId))})");

            var designList = await _iDesignRepository.GetListAsync($"SELECT * FROM Inman_Design WHERE Id in({string.Join(",", goodsList.Select(d => d.DesignID))})");

            foreach (var goods in goodsList)
            {
                goods.Design = designList.FirstOrDefault(d => d.Id == goods.DesignID);
            }

            foreach (var product in list)
            {
                product.Goods = goodsList.FirstOrDefault(d => d.Id == product.GoodsId);
                product.ProductSN = product.Goods?.ProductSN;
            }
            

            var response = new ProductResponse();
            response.Products.AddRange(list);
            return response;
        }
     


    }
}
