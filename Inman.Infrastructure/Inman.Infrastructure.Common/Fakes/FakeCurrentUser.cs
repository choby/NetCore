using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public class FakeCurrentUser : ICurrentUser
    {
        public string LoginName { get; set; }

        public string NickName { get; set; }

        public int LoginId { get; set; }

        public string Email { get; set; }
    }
}
