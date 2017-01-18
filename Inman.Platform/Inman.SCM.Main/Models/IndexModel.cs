using Inman.Platform.ServiceStub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inman.SCM.Main.Models
{
    public class IndexModel
    {
        public IndexModel()
        {
            StockItems = new List<StockItem>();
            List1 = new List<Product>();
            List2 = new List<Product>();
        }
        public IEnumerable<StockItem> StockItems { get; set; }
        public IEnumerable<Product> List1 { get; set; }
        public IEnumerable<Product> List2 { get; set; }
    }
}
