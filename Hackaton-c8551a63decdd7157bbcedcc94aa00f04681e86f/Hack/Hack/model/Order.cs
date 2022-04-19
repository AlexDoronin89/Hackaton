using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack.model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int ProductCount { get; set; }
        public int Price { get; set; }
        public int SupplierId { get; set; }
        public int PurchaserId { get; set; }
    }
}
