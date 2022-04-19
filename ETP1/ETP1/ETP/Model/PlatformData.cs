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

        public event Action AddedOrder;
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
        //public void AddOrder(int id, string product, int productCount, int price, int supplierId, int purchaserId)
        //{
        //    Order[id] = new Order(id, product, productCount, price, supplierId, purchaserId);
        //    AddedBox?.Invoke();
        //}

        //public void RemoveOrder(int index)
        //{
        //    Order.RemoveAt(index);
        //    RemovedBox?.Invoke();
        //}

        //public void UpdateOrder(int id, string product, int productCount, int price, int supplierId, int purchaserId)
        //{
        //    Order[id] = new Order(id, product, productCount, price, supplierId, purchaserId);
        //    UpdatedBox?.Invoke();
        //}

        //public IReadOnlyList<IReadOnlyOrder> GetOrder()
        //{
        //    IReadOnlyList<IReadOnlyOrder> order;
        //    List<Order> orderList = new List<Order>();

        //    for (int i = 0; i < Order.Count; i++)
        //    {
        //            orderList.Add(Order[i]);
        //    }

        //    order = orderList;

        //    return Order;
        //}
        //public void DropOrderNumbers(int orderNumber)
        //{
        //    for (int i = orderNumber; i < Order.Count; i++)
        //    {
        //          Order[i].DropId();
        //    }
        //}
    }
}

