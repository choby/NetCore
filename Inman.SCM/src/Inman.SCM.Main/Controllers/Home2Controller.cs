﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using IdentityModel.Client;
using System.Linq;
using System.Security.Claims;
using IdentityModel;
using static Inman.Platform.ServiceStub.StockItemService;
using Inman.Platform.ServiceStub;
using System.Collections.Generic;
using static Inman.Platform.ServiceStub.ProductService;
using Inman.Platform.ServiceStub.Data;
using Inman.SCM.Main.Models;
using Microsoft.AspNetCore.Http;
using Inman.Infrastructure.Common.IOC;

namespace Inman.SCM.Controllers
{
    //[HandleErrorAttribute]
    public class Home2Controller : Controller
    {

        IHttpContextAccessor _httpContextAccessor;
        StockItemServiceClient _stockItemServiceClient;
        ProductServiceClient _productServiceClient;
        
        public Home2Controller(StockItemServiceClient stockItemServiceClient,
            ProductServiceClient productServiceClient,
            
            IHttpContextAccessor httpContextAccessor)
        {
            _stockItemServiceClient = stockItemServiceClient;
            _productServiceClient = productServiceClient;
         
            _httpContextAccessor = httpContextAccessor;
        }
        
        public  IActionResult Index(string get = "1")
        {
            IndexModel model = new IndexModel();
            var productList = new List<Product>();
            //for (int i = 0; i < 1000; i++)
            //{
                productList = new List<Product>();
            //                var request = new StockItemRequest { Quantity = 10 };
            //                request.StockItemId.AddRange(new List<int> {1004
            //,1005
            //,1006
            //,1007
            //,1008
            //,1009
            //,1010
            //,1011
            //,1012
            //,1013
            //,1014
            //,1015
            //,1016
            //,1017
            //,1018
            //,1019
            //,1020
            //,1021
            //,1022
            //,1023
            //,1024
            //,1025
            //,1026
            //,1027
            //,1028
            //,1029
            //,1030
            //,1031
            //,1032
            //,1033
            //,1034
            //,1035
            //,1036
            //,1037
            //,1038
            //,1039
            //,1040
            //,1041
            //,1042
            //,1043
            //,1044
            //,1045
            //,1046
            //,1047
            //,1048
            //,1049
            //,1050
            //,1051
            //,1052
            //,1053
            //,1054
            //,1055
            //,1056
            //,1057
            //,1058
            //,1059
            //,1060
            //,1061
            //,1062
            //,1063
            //,1065 });
            //    var list = new List<StockItem>();
            //    var streamCall = _stockItemServiceClient.GetStockItemList(request);
            //model.StockItems = streamCall.StockItems.ToList();

            //list.ForEach(t => t.Id = 1000);

            if (get == "1")
            {
                //不拼装
                var productRequest = new ProductRequest();
                var productStreamCall = _productServiceClient.GetProductList(productRequest);
                model.List1 = productStreamCall.Products.ToList();
                model.ExecuteTime = productStreamCall.ExecuteTime;
            }
            else
            {
                //拼装
                var productRequest = new ProductRequest();
                productRequest.Page = 1;
                productRequest.PageSize = 20;
                 var productStreamCall = _productServiceClient.GetProductList(productRequest);
                model.ExecuteTime = productStreamCall.ExecuteTime;
               productList.AddRange(productStreamCall.Products);

                productList.ForEach(t => t.Id = 1020303);

                //var goodsRequest = new GoodsRequest();
                //goodsRequest.GoodsId.AddRange(productList.Select(t => t.GoodsId));
                //var goodsStreamCall = _goodsServiceClient.GetGoodsList(goodsRequest);
                //var goodsList = new List<Goods>();
                //goodsList.AddRange(goodsStreamCall.Goodses);
                // goodsList.ForEach(t => t.Id = 1203244567);

                //productList.ForEach(t =>
                //{
                //    var goods = goodsList.FirstOrDefault(d => d.Id == t.GoodsId);
                //    if (goods != null)
                //    {
                //        //goods.Design = t.Goods.Design;
                //        t.Goods = goods;
                //    }

                //});
                model.List2 = productList;
                // }
            }
           
            return Json(model);
           // return View(model);
        }

        [Authorize]
        public IActionResult Secure()
        {
            ViewData["Message"] = "Secure page.";
            
            return View();
        }

        public async Task Logout()
        {
            await HttpContext.Authentication.SignOutAsync("Cookies");
            await HttpContext.Authentication.SignOutAsync("oidc");
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<IActionResult> CallApiUsingClientCredentials()
        {
            //var disco = await DiscoveryClient.GetAsync("http://localhost:5000");
            //var tokenClient = new TokenClient(disco.TokenEndpoint, "mvc", "secret");
            var tokenClient = new TokenClient("http://localhost:5000/connect/token", "mvc", "secret");
            var tokenResponse = await tokenClient.RequestClientCredentialsAsync("api1");

            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.AccessToken);
            var content = await client.GetStringAsync("http://localhost:5001/identity");

            ViewBag.Json = JArray.Parse(content).ToString();
            return View("json");
        }

        public async Task<IActionResult> CallApiUsingUserAccessToken() 
        {
            var accessToken = await HttpContext.Authentication.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.SetBearerToken(accessToken);
            var content = await client.GetStringAsync("http://localhost:5001/identity");

            ViewBag.Json = JArray.Parse(content).ToString();
            return View("json");
        }

        public async Task<IActionResult> RequestUserInfo()
        {
             var discoveryClient = new DiscoveryClient("http://localhost:5000/");
            var doc = await discoveryClient.GetAsync();

            //// //Authorize Endpoint

            //var request = new AuthorizeRequest(doc.AuthorizeEndpoint);
            //var url = request.CreateAuthorizeUrl(
            //    clientId: "mvc",
            //    responseType: OidcConstants.ResponseTypes.CodeIdToken,
            //    responseMode: OidcConstants.ResponseModes.FormPost,
            //    redirectUri: "http://localhost:5002",
            //    state: CryptoRandom.CreateUniqueId(),
            //    nonce: CryptoRandom.CreateUniqueId());

            // var response = new AuthorizeResponse(url);

            // var accessToken = response.AccessToken;
            // var idToken = response.IdentityToken;
            // var state = response.State;



            // //var tokenEndpoint = doc.TokenEndpoint;



           var  accessToken = await HttpContext.Authentication.GetTokenAsync("access_token");
            var userInfoClient = new UserInfoClient(doc.UserInfoEndpoint);
            var response2 = await userInfoClient.GetAsync(accessToken);
            ViewBag.Json = response2.Json.ToString(); //JArray.Parse(response.Json).ToString();

            //var accessToken = await HttpContext.Authentication.GetTokenAsync("access_token");

            //var client = new HttpClient();
            //client.SetBearerToken(accessToken);
            //var content = await client.GetAsync("http://localhost:5000/connect/userinfo");

            //ViewBag.Json = JArray.Parse(content.).ToString();

            return View("json");
        }
    }
}
