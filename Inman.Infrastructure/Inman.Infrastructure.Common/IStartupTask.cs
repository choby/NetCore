using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public interface IStartupTask
    {
        void Exec();

        int Order { get; }
    }
}
