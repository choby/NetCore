using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public interface ICurrentUser
    {
        string LoginName { get; set; }

        string NickName { get; set; }

        int LoginId { get; set; }

        string Email { get; set; }
    }
}
