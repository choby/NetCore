using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Inman.Infrastructure.Common.Extensions
{
    public static class WcfExtension
    {
        public static void Using<T>(T serviceClient, Action<T> action) where T : ICommunicationObject
        {
            try
            {
                action(serviceClient);
                serviceClient.Close();
            }
            catch (CommunicationException)
            {
                serviceClient.Abort();
                throw;
            }
            catch (TimeoutException)
            {
                serviceClient.Abort();
                throw;
            }
            catch (Exception)
            {
                serviceClient.Abort();
                throw;
            }
        }
    }
}
