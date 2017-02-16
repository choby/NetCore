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
using static Inman.Platform.ServiceStub.StockItemService;
using Inman.Platform.ServiceStub;
using System.Collections.Generic;
using static Inman.Platform.ServiceStub.ProductService;
using static Inman.Platform.ServiceStub.GoodsService;
using Inman.Platform.ServiceStub.Data;
using Inman.SCM.Main.Models;

namespace Inman.SCM.Controllers
{
    //[HandleErrorAttribute]
    public class TelerikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
