using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.Security;
using Inman.Infrastructure.Common;

namespace Inman.Infrastructure.Web
{
    public class FakeAuthenticationService : FormsAuthenticationService
    {
        public override TicketData GetAuthenticatedTicketData()
        {
            try
            {
                var ticketData = base.GetAuthenticatedTicketData();
                if (ticketData != null)
                { return ticketData; }
            }
            catch (Exception)
            {
            }

            return new TicketData
            {
                UserName = RunModel.GetInstance().DebugModel.UserName
            };
        }
    }
}
