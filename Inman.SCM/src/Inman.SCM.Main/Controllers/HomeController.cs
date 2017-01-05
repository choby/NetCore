using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using IdentityModel.Client;
using System.Security.Claims;
using IdentityModel;

namespace Inman.SCM.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View(User);
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
            // var discoveryClient = new DiscoveryClient("http://localhost:5000/");
            // var doc = await discoveryClient.GetAsync();

            // //Authorize Endpoint

            // var request = new AuthorizeRequest(doc.AuthorizeEndpoint);
            // var url = request.CreateAuthorizeUrl(
            //     clientId: "mvc",
            //     responseType: OidcConstants.ResponseTypes.CodeIdToken,
            //     responseMode: OidcConstants.ResponseModes.FormPost,
            //     redirectUri: "http://localhost:5002",
            //     state: CryptoRandom.CreateUniqueId(),
            //     nonce: CryptoRandom.CreateUniqueId());

            // var response = new AuthorizeResponse(url);

            // var accessToken = response.AccessToken;
            // var idToken = response.IdentityToken;
            // var state = response.State;



            // //var tokenEndpoint = doc.TokenEndpoint;



            //  accessToken = await HttpContext.Authentication.GetTokenAsync("access_token");
            // var userInfoClient = new UserInfoClient(doc.UserInfoEndpoint);
            //var response2 = await  userInfoClient.GetAsync(accessToken);
            // ViewBag.Json = response2.Json.ToString(); //JArray.Parse(response.Json).ToString();

            var accessToken = await HttpContext.Authentication.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.SetBearerToken(accessToken);
            var content = await client.GetStringAsync("http://localhost:5000/connect/userinfo");

            ViewBag.Json = JArray.Parse(content).ToString();

            return View("json");
        }
    }
}
