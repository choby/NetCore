using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json.Linq;
using IdentityModel.Client;
using System.Linq;
using System.Security.Claims;
using IdentityModel;
using Inman.SCM.Main.Models;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json;
using static Inman.Platform.ServiceStub.ProductService;
using Inman.Platform.ServiceStub;
using Kendo.Mvc.Infrastructure;
using Inman.Platform.ServiceStub.Data;
using System.Diagnostics;

namespace Inman.SCM.Controllers
{
    //[HandleErrorAttribute]
    public class HomeController : Controller
    {
        ProductServiceClient _productServiceClient;

        public HomeController(ProductServiceClient productServiceClient            )
        {
            _productServiceClient = productServiceClient;
          
           
        }
        public  IActionResult Index()
        {
            //using (var source = new CancellationTokenSource())
            //{
            //    RunAsync(null, source.Token).GetAwaiter().GetResult();
            //}
            //拼装
            //using (var source = new CancellationTokenSource())
            //{
            //    var productRequest = new ProductRequest();
            //    productRequest.ProductId = new Thrift.Collections.THashSet<int>();

            //    await _productServiceClient.OpenTransportAsync(source.Token);
            //    var productList = await _productServiceClient.GetProductListAsync(productRequest, source.Token);

               

            

            //    var goodsRequest = new GoodsRequest();
            //    goodsRequest.GoodsId = new Thrift.Collections.THashSet<int>();
            //    goodsRequest.GoodsId.AddRange(productList.Products.Select(t => t.GoodsId));

            //    await _goodsServiceClient.OpenTransportAsync(source.Token);
            //    var goodsList = await _goodsServiceClient.GetGoodsListAsync(goodsRequest, source.Token);
               

            //    foreach (Product item in productList.Products)
            //    {
            //        var goods = goodsList.Goodses.FirstOrDefault(d => d.Id == item.GoodsId);
            //        if (goods != null)
            //        {
            //            //goods.Design = item.Goods.Design;
            //            item.Goods = goods;
            //        }
            //    }
            //    //model.List2 = productList;

                return View();
           // }
        }

        [HttpPost]

        public async Task<IActionResult> Read([DataSourceRequest] DataSourceRequest request)

        {
           
            //Stopwatch.StartNew();
            var queryRequest = new ProductRequest();
            queryRequest.Page = request.Page;
            queryRequest.PageSize = request.PageSize;
            var demandDescriptor = new DemandDescriptor();
            demandDescriptor.Filter = Request.Form["filter"];
            queryRequest.DemandDescriptor = demandDescriptor;
            //var filters = FilterDescriptorFactory.Create(demandDescriptor.Filter);
            //if (request.Filters != null && request.Filters.Count > 0)
            //{
            //    var filter = request.Filters[0] as Kendo.Mvc.FilterDescriptor;
            //    demandDescriptor.Member = filter.Member;
            //    demandDescriptor.Value = filter.Value.ToString();
            //    queryRequest.FilterDescriptor.Operator = filter.Operator.ToString();
            //    // new   Grpc.Core.Metadata().Add(new Grpc.Core.Metadata.Entry())
            //}
            var response = await _productServiceClient.GetProductListAsync(queryRequest);
            DataSourceResult result = new DataSourceResult
            {
                Data = response.Products,
                Total = response.Total,
                AggregateResults = new List<AggregateResult>()
            };
            
            //return Json(Stopwatch.GetTimestamp());
            return Json(result);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var queryRequest = new ProductRequest();
            queryRequest.ProductId.Add(id);
            var product = await _productServiceClient.GetProductAsync(queryRequest);

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product model)
        {
            ProductUpdate update = new ProductUpdate();
            update.Product = model;
            var response = await _productServiceClient.UpdateProductAsync(update);
            if (response.Success)
            {
                try
                {
                    TempData["msg"] = "编辑成功";
                }
                catch (Exception ex)
                {
                }
                return Redirect("/");
            }
            else
            {
                try
                {
                    TempData["msg"] = "保存失败";
                }
                catch (Exception ex)
                {
                }
                return View(model);
            }
        }


        public IActionResult Add()
        {
            var product = new Product();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product model)
        {
            ProductUpdate addEntity = new ProductUpdate();
            addEntity.Product = model;
            addEntity.Product.DesignID = 15168;
            addEntity.Product.ColorId = 66;
            var response = await _productServiceClient.AddProductAsync(addEntity);
            if (response.Success)
            {
                this.
                   TempData["msg"] = "添加成功";
                return Redirect("/");
            }
            else
            {
                TempData["msg"] = "添加失败";
                return View(model);
            }
        }
        public async Task<IActionResult> Delete([Bind(Prefix = "models")]IEnumerable<BaseModel> models)
        {
            ProductDelete delete = new ProductDelete();
            delete.Id.AddRange(models.Select(t => t.Id));
            await _productServiceClient.DeleteProductAsync(delete);
            return Content("");
        }


    }

}
