include "data.thrift"

namespace cpp Inman.Platform.ServiceStub.Thrift
namespace d Inman.Platform.ServiceStub.Thrift
namespace dart Inman.Platform.ServiceStub.Thrift
namespace java Inman.Platform.ServiceStub.Thrift
namespace php Inman.Platform.ServiceStub.Thrift
namespace perl Inman.Platform.ServiceStub.Thrift
namespace haxe Inman.Platform.ServiceStub.Thrift
namespace netcore Inman.Platform.ServiceStub.Thrift

service GoodsService {
  data.Goods GetGoods(1:GoodsRequest request);
  GoodsList GetGoodsList(1:GoodsRequest request);
}
struct GoodsRequest
{
	1:i32 Quantity;
	2:set<i32> GoodsId;
}
struct GoodsList
{
	1:i32 Total;
	2:set<data.Goods> Goodses;
}