using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ETP.Model.Order;

namespace ETP.Model
{
    public class Order : IReadOnlyOrder
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int ProductCount { get; set; }
        public int Price { get; set; }
        public bool IsPaid { get; set; }

        public Order(int id, string product, int productCount, int price)
        {
            Id = id;
            Product = product;
            ProductCount = productCount;
            Price = price;
            IsPaid = false;
        }
        public void Unpaiding()
        {
            IsPaid = true;
        }

        public void DropId()
        {
            Id--;
        }
        public interface IReadOnlyOrder
        {
            int Id { get; }
            string Product { get; }
            int ProductCount { get; }
            int Price { get; }
            bool IsPaid { get; }
        }
    }
}
