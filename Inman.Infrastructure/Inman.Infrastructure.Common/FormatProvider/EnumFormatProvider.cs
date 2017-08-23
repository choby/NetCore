using Inman.Infrastructure.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inman.Infrastructure.Common.FormatProvider
{
    public class EnumFormatProvider<T> : ICustomFormatter, IFormatProvider where T : struct
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            return (arg.CastTo<T>()).GetEnumDescription();
        }

        public object GetFormat(Type formatType)
        {
            return this;
        }
    }
}
