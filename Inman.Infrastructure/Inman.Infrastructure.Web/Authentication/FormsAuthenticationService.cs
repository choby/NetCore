using Microsoft.AspNetCore.Http;
using System;

namespace Inman.Infrastructure.Web
{
    public class FormsAuthenticationService : IAuthenticationService
    {
        private readonly TimeSpan _expirationTimeSpan;
        private TicketData _cachedUserData;
        HttpContext _httpContext;

        public FormsAuthenticationService()
        {
            _expirationTimeSpan = FormsAuthentication.Timeout;
        }

        public virtual void SignIn(TicketData ticketData, bool createPersistentCookie = false)
        {
            var now = DateTime.UtcNow.ToLocalTime();

            var ticket = new FormsAuthenticationTicket(
                                                            1,
                                                            ticketData.UserName,
                                                            now,
                                                            now.Add(_expirationTimeSpan),
                                                            createPersistentCookie,
                                                            new JavaScriptSerializer().Serialize(ticketData),
                                                            FormsAuthentication.FormsCookiePath
                                                       );

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);

            //var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket) { HttpOnly = true };

            //if (ticket.IsPersistent)
            //{
            //    cookie.Expires = ticket.Expiration;
            //}
            //cookie.Secure = FormsAuthentication.RequireSSL;
            //cookie.Path = FormsAuthentication.FormsCookiePath;
            //if (FormsAuthentication.CookieDomain != null)
            //{
            //    cookie.Domain = FormsAuthentication.CookieDomain;
            //}

            _httpContext.Response.Cookies.Append(FormsAuthentication.FormsCookieName, encryptedTicket);
            _cachedUserData = ticketData;
        }

        public virtual void SignOut()
        {
            _cachedUserData = null;
            FormsAuthentication.SignOut();
        }

        public virtual TicketData GetAuthenticatedTicketData()
        {
            if (_cachedUserData != null)
                return _cachedUserData;

            if (HttpContext.Current == null ||
                HttpContext.Current.Request == null ||
                !HttpContext.Current.Request.IsAuthenticated ||
                !(HttpContext.Current.User.Identity is FormsIdentity))
            {
                return null;
            }

            var formsIdentity = (FormsIdentity)HttpContext.Current.User.Identity;
            var customer = GetAuthenticatedUserDataFromTicket(formsIdentity.Ticket);
            if (customer != null)
            { _cachedUserData = customer; }
            return _cachedUserData;
        }

        protected virtual TicketData GetAuthenticatedUserDataFromTicket(FormsAuthenticationTicket ticket)
        {
            if (ticket == null)
            { throw new ArgumentNullException("ticket"); }

            return new JavaScriptSerializer().Deserialize<TicketData>(ticket.UserData);
        }
    }
}
