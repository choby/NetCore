using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Inman.Infrastructure.Web
{
    public class PersonalCache
    {
        private PersonalCache()
        {
        }

        private static readonly PersonalCache S_Instance = new PersonalCache();

        public object this[string key]
        {
            get { return HttpContext.Current.Session[key]; }
            set { HttpContext.Current.Session[key] = value; }
        }

        public void Remove(string key)
        {
            if (this[key] != null)
            { HttpContext.Current.Session.Remove(key); }
        }

        public static PersonalCache Instance
        {
            get { return S_Instance; }
        }
    }
}
