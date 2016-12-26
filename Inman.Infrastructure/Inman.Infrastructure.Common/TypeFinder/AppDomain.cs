using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public  class AppDomain
    {
        public class CurrentDomain
        {
            public static string BaseDirectory
            {
                get
                {
                    return AppContext.BaseDirectory;
                }

            }

        }
    }
}
