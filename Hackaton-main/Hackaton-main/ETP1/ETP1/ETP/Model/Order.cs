using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Model
{
    class Order
    {
        private int _id;
        public int Id { get; set; }
        public int ProductCount { get; set; }
        public string Product { get; set; }
        public Supplier Supplier { get; set; }
        public int Price { get; set; }

        public Order(int productCount, int price, Supplier supplier, string product)
        {
            Id = ++_id;
            ProductCount = productCount;
            Price = price;
            Supplier = supplier;
            Product = product;
        }
       
        public interface IReadOnlyOrder
        {
            int ProductCount { get; }
            int ProductPrcice { get; }
        }


    }
}
