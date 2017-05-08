using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Inman.Platform.ServiceStub.Thrift;
using Inman.Platform.ServiceStub.Thrift.Data;

namespace Inman.Platform.Service
{
    public class GoodsAsyncHandler : GoodsService.IAsync
    {
        IRepository<Goods> _iRepository;
        public GoodsAsyncHandler(IRepository<Goods> iRepository)
        {
            _iRepository = iRepository;
        }
        public  Task<Goods> GetGoodsAsync(GoodsRequest request, CancellationToken cancellationToken)
        {
            return _iRepository.GetEntityAsync("SELECT * FROM Inman_Goods WHERE Id=@0", request.GoodsId);
        }

        public async Task<GoodsList> GetGoodsListAsync(GoodsRequest request, CancellationToken cancellationToken)
        {
            string sql = "SELECT Id, DesignID,ProductSN ,ProductCategory1,ProductCategory2,ProductCategory3,Brand,ProductName,ProductYear,Season,ExecStandard,SafetyCass,Component,DevCost FROM Inman_Goods";
            if (request.GoodsId.Count > 0)
                sql = $"{sql} WHERE Id in ({string.Join(",", request.GoodsId)})";

            var list = await _iRepository.GetListAsync(sql);
            var response = new GoodsList();
            response.Goodses = new Thrift.Collections.THashSet<Goods>();
            foreach (var item in list)
            {
                response.Goodses.Add(item);
            }
            return response;
        }
    }
}
