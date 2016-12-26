using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public partial interface IDateTimeHelper
    {
        Int64 ConvertToInt(DateTime dt);
        DateTime ConvertToDateTime(Int64 number);
    }
}
