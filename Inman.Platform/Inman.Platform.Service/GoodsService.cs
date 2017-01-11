using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Inman.Platform.ServiceStub;
using Inman.Platform.Data.Repository;
using static Inman.Platform.ServiceStub.GoodsService;
using Inman.Platform.ServiceStub.Data;

namespace Inman.Platform.Service
{
    public class GoodsServiceImpl : GoodsServiceBase
    {
        IRepository<Goods> _iRepository;
        public GoodsServiceImpl(IRepository<Goods> iRepository)
        {
            _iRepository = iRepository;
        }
        public override Task<Goods> GetGoods(GoodsRequest request, ServerCallContext context)
        {
            return _iRepository.GetEntityAsync("SELECT * FROM Inman_Goods WHERE Id=@0", request.GoodsId);
        }
       
        public override async Task<GoodsResponse> GetGoodsList(GoodsRequest request, ServerCallContext context)
        {
            string sql = "SELECT Id, DesignID,ProductSN ,ProductCategory1,ProductCategory2,ProductCategory3,Brand,ProductName,ProductYear,Season,ExecStandard,SafetyCass,Component,DevCost FROM Inman_Goods";
            if (request.GoodsId.Count > 0)
                sql = $"{sql} WHERE Id in ({string.Join(",", request.GoodsId)})";

            var list = await _iRepository.GetListAsync(sql);
            var response = new GoodsResponse();
            response.Goodses.AddRange(list);
            return response;
        }


    }
}
