using ETP.Model;
using ETP.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);      
            PlatformData platformData = new PlatformData(new List<Order>());
            FormPurchaser viewPurchaser = new FormPurchaser();
            FormTablePresenter purchaserPresenter = new FormTablePresenter(platformData, viewPurchaser);
            Application.Run(viewPurchaser);
        }
    }
}
