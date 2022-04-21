using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ETP.Model.Order;

namespace ETP.Model
{
    class PlatformData
    {
        public List<Order> Order { get; private set; }
        public int OrderNumbers { get; private set; }

        public event Action AddingOrder;
        public event Action RemovedOrder;
        public event Action UpdatedOrder;
        public PlatformData(List<Order> order)
        {
            Order = order;
            OrderNumbers = 0;
        }
        //public void Create(int orderCount)
        //{
        //    for (int i = 0; i < Order.Count; i++)
        //    {
        //         Order[i].Unpaiding();
        //         UpdatedBox?.Invoke();                       
        //    }
        //}
        //public void AddOrder(int id, string product, int productCount, int price)
        //{
        //    Order[id] = new Order(id, productCount, supplier, product);
        //    AddingOrder?.Invoke();
        //}

        public void RemoveOrder(int index)
        {
            Order.RemoveAt(index);
            RemovedOrder?.Invoke();
        }

        //public void DropOrderNumbers(int orderNumber)
        //{
        //    for (int i = orderNumber; i < Order.Count; i++)
        //    {
        //          Order[i].DropId();
        //    }
        //}
    }
}

