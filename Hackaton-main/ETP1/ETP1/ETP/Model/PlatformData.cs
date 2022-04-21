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
        public List<Purchaser> Purchasers { get; private set; }
        public List<Supplier> Suppliers { get; private set; }
        public int OrderNumbers { get; private set; }

        public event Action AddedOrder;
        public event Action RemovedOrder;
        public event Action UpdatedOrder;
        public event Action OpenedMainFormPurchaser;
        public event Action OpenedMainFormSupplier;
        public PlatformData(List<Order> order)
        {
            Order = order;
            OrderNumbers = 0;
            Purchasers = new List<Purchaser>();
            Suppliers = new List<Supplier>();
        }
        public void CheckPassword(string login, string password)
        {
            int temp = 0;
            for (int i = 0; i < Purchasers.Count; i++)
            {
                if(Purchasers[i].Login == login && Purchasers[i].Password == password)
                {
                    OpenedMainFormPurchaser?.Invoke();
                    temp++;
                }
            }
            if(temp == 0)
            {
                for (int i = 0; i < Suppliers.Count; i++)
                {
                    if (Suppliers[i].Login == login && Suppliers[i].Password == password)
                    {
                        OpenedMainFormSupplier?.Invoke();
                        temp++;
                    }
                }
            }
            if(temp == 0)
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль");
            }
        }
        public void BuyOrder(int index)
        {
            Order.RemoveAt(index);
        }
        public void Create(string name, string password, string fName, string sName, string tName, string mail, string phoneNumber, bool purchaser, bool supplier)
        {
            if(purchaser == true)
            {
                Purchasers.Add(new Purchaser(name, password, fName, sName, tName, mail, phoneNumber));
            }
            else if(supplier == true)
            {
                Suppliers.Add(new Supplier(name, password, fName, sName, tName, mail, phoneNumber));
            }
        }
        public void AddOrder(string product, int productCount, int price)
        {
            Order.Add(new Order(OrderNumbers, product, productCount, price));
            OrderNumbers++;
            AddedOrder?.Invoke();
        }

        public void RemoveOrder(int index)
        {
            Order.RemoveAt(index);
            RemovedOrder?.Invoke();
        }

        public void UpdateOrder(int id, string product, int productCount, int price)
        {
            Order[id] = new Order(id, product, productCount, price);
            UpdatedOrder?.Invoke();
        }

        public IReadOnlyList<IReadOnlyOrder> GetOrder()
        {
            IReadOnlyList<IReadOnlyOrder> order;
            List<Order> orderList = new List<Order>();

            for (int i = 0; i < Order.Count; i++)
            {
                orderList.Add(Order[i]);
            }

            order = orderList;

            return order;
        }
        public void DropOrderNumbers(int orderNumber)
        {
            for (int i = orderNumber; i < Order.Count; i++)
            {
                Order[i].DropId();
            }
        }
    }
}

