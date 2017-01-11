using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Inman.Platform.ServiceStub;
using static Inman.Platform.ServiceStub.StockItemService;
using Inman.Platform.Data.Repository;
using Inman.Platform.ServiceStub.Data;

namespace Inman.Platform.Service
{
    public class StockItemServiceImpl : StockItemServiceBase
    {
        IRepository<StockItem> _iRepository;
        public StockItemServiceImpl(IRepository<StockItem> iRepository)
        {
            _iRepository = iRepository;
        }
        public override Task<StockItem> GetStockItem(StockItemRequest request, ServerCallContext context)
        {
            return _iRepository.GetEntityAsync("SELECT * FROM Inman_StockItem WHERE Id=@0", request.StockItemId);
        }
        public override async Task<StockItemResponse> GetStockItemList(StockItemRequest request, ServerCallContext context)
        {
            string sql = "SELECT TOP 15 Id,ItemName,ItemCode FROM Inman_StockItem";
            if (request.StockItemId.Count > 0)
                sql = $"{sql} WHERE Id in ({string.Join(",", request.StockItemId)})";

            var list = await _iRepository.GetListAsync(sql);
            var response = new StockItemResponse();
            response.StockItems.AddRange(list);
            return response;
        }
    }
}
