include "data.thrift"

namespace cpp ServiceStub
namespace d Inman.Platform.ServiceStub.Thrift
namespace dart Inman.Platform.ServiceStub.Thrift
namespace java Inman.Platform.ServiceStub.Thrift
namespace php Inman.Platform.ServiceStub.Thrift
namespace perl Inman.Platform.ServiceStub.Thrift
namespace haxe Inman.Platform.ServiceStub.Thrift
namespace netcore Inman.Platform.ServiceStub.Thrift

service ProductService {
 
  data.Product GetProduct(1:ProductRequest request);
  ProductList  GetProductList(1:ProductRequest request);
}
struct ProductRequest
{
	1:i32 Quantity;
	2:set<i32> ProductId;
}
struct ProductList
{
	1:i32 Total ;
	2:set<data.Product> Products ;
	3:string ExecuteTime;
}