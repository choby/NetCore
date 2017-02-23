using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using IdentityModel.Client;
using System.Linq;
using System.Security.Claims;
using IdentityModel;
using System.Collections.Generic;
using Inman.SCM.Main.Models;
using System.Threading;
using Thrift.Transports;
using System;
using Thrift.Protocols;
using System.Net;
using Thrift.Transports.Client;
using Thrift;
using System.Security.Cryptography.X509Certificates;
using Kendo.Mvc.Extensions;
using Inman.Platform.ServiceStub.Thrift;
using Inman.Platform.ServiceStub.Thrift.Data;

namespace Inman.SCM.Controllers
{
    //[HandleErrorAttribute]
    public class ThriftController : Controller
    {
        ProductService.Client _productServiceClient;
        GoodsService.Client _goodsServiceClient;
       
        public ThriftController(ProductService.Client productServiceClient,
            GoodsService.Client goodsServiceClient
            )
        {
            _productServiceClient = productServiceClient;
            _goodsServiceClient = goodsServiceClient;
           
        }
        public async Task<IActionResult> IndexAsync()
        {
            //using (var source = new CancellationTokenSource())
            //{
            //    RunAsync(null, source.Token).GetAwaiter().GetResult();
            //}
            //拼装
            using (var source = new CancellationTokenSource())
            {
                var productRequest = new ProductRequest();
                productRequest.ProductId = new Thrift.Collections.THashSet<int>();

                await _productServiceClient.OpenTransportAsync(source.Token);
                var productList = await _productServiceClient.GetProductListAsync(productRequest, source.Token);

                //productList.AddRange(productList.Products);

                // productList.ForEach(t => t.Id = 1020303);

                //var goodsRequest = new GoodsRequest();
                //goodsRequest.GoodsId = new Thrift.Collections.THashSet<int>();
                //goodsRequest.GoodsId.AddRange(productList.Products.Select(t => t.GoodsId));

                //await _goodsServiceClient.OpenTransportAsync(source.Token);
                //var goodsList = await _goodsServiceClient.GetGoodsListAsync(goodsRequest, source.Token);
                //var goodsList = new List<Goods>();
                //goodsList.AddRange(goodsStreamCall.Goodses);
                // goodsList.ForEach(t => t.Id = 1203244567);

                //foreach (Product item in productList.Products)
                //{
                //    var goods = goodsList.Goodses.FirstOrDefault(d => d.Id == item.GoodsId);
                //    if (goods != null)
                //    {
                //        //goods.Design = item.Goods.Design;
                //        item.Goods = goods;
                //    }
                //}
                //model.List2 = productList;

                return Json(productList);
            }
        }
       
       
    }

}
