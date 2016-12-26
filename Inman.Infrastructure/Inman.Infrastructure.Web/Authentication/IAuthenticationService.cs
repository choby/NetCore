using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Inman.Infrastructure.Web
{
    public interface IAuthenticationService
    {
        void SignIn(TicketData ticketData, bool createPersistentCookie);

        void SignOut();

        TicketData GetAuthenticatedTicketData();
    }
}
