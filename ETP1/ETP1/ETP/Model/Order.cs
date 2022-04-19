using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Model
{
    class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int ProductCount { get; set; }
        public int Price { get; set; }
        public int SupplierId { get; set; }
        public int PurchaserId { get; set; }
        public bool IsPaid { get; set; }

        public Order(int id, string product, int productCount, int price, int supplierId, int purchaserId)
        {
            Id = id; 
            Product = product; 
            ProductCount = productCount;
            Price = price;
            SupplierId = supplierId;
            PurchaserId = purchaserId;
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
            int ProductCount { get; }
            bool IsPaid { get; }
        }
    }
}
