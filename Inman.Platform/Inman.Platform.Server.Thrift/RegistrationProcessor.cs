using Inman.Platform.Service;
using Inman.Platform.ServiceStub.Thrift;
using Microsoft.Extensions.DependencyInjection;

using Thrift;

namespace Inman.Platform.ThriftServer
{
    public class RegistrationProcessor : IRegistrationProcessor
    {
        public void RegistrationsFor(TMultiplexedProcessor processor)
        {
            var productHandler = Program.serviceProvider.GetService<ProductAsyncHandler>();
            var goodsHandler = Program.serviceProvider.GetService<GoodsAsyncHandler>();

            var productProcessor = new ProductService.AsyncProcessor(productHandler);
            var goodsProcessor = new GoodsService.AsyncProcessor(goodsHandler);
            
            processor.RegisterProcessor(nameof(ProductService), productProcessor);
            processor.RegisterProcessor(nameof(GoodsService), goodsProcessor);
                        
        }
    }
}
