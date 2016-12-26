using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Inman.Infrastructure.Common;
using Inman.Infrastructure.IOC;

namespace Inman.Infrastructure.Web
{
    public class IgnoredActionMethod
    {
        public string Controller { get; set; }

        public string Action { get; set; }
    }

    public class MemberOnlyAttribute : AuthorizeAttribute
    {
        protected IAuthenticationService _authenticationService;

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = new JsonResult()
                    {
                        Data = new ValidationResult()
                        {
                            Success = false,
                            Redirect = true
                        },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };

            }
            else
            {
                filterContext.Result = new RedirectResult("/RedirectToLogin.html");
            }
        }

        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            return EngineContext.Current.Resolve<IAuthenticationService>().GetAuthenticatedTicketData() != null;
        }
    }
}
