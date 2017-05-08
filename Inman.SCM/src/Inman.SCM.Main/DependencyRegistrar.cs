using Inman.Infrastructure.Common.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Inman.Infrastructure.Common;
using System.IO;
using Grpc.Core;
using static Inman.Platform.ServiceStub.StockItemService;
using static Inman.Platform.ServiceStub.ProductService;


namespace Inman.SCM.Main
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 0;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //使用openssl证书
            //证书保存可以是磁盘文件，也可以是数据库记录
            var cacert = File.ReadAllText("OpenSSL/ca.crt");
            var clientcert = File.ReadAllText("OpenSSL/client.crt");
            var clientkey = File.ReadAllText("OpenSSL/client.key");
            var ssl = new SslCredentials(cacert, new KeyCertificatePair(clientcert, clientkey));
            //创建使用证书的通信管道
            builder.Register<Channel>(sp => new Channel("192.168.7.213:50052", ChannelCredentials.Insecure)).SingleInstance();
            builder.RegisterType<StockItemServiceClient>().As<StockItemServiceClient>().InstancePerDependency();
            builder.RegisterType<ProductServiceClient>().As<ProductServiceClient>().InstancePerDependency();
           
            //services.AddSingleton(typeof(Channel), sp => new Channel("192.168.7.213:50052", ChannelCredentials.Insecure)); //生命周期使用单例//
            //services.AddTransient(typeof(StockItemServiceClient), typeof(StockItemServiceClient));
            //services.AddTransient(typeof(ProductServiceClient), typeof(ProductServiceClient));
            //services.AddTransient(typeof(GoodsServiceClient), typeof(GoodsServiceClient));


        }
    }
}
