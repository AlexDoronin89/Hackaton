using ETP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ETP.Model.Order;

namespace ETP
{
    public partial class FormPurchaser : Form
    {
        public event Action<string, int, int> AddingOrder;
        public event Action<int, string, int, int> UpdatingOrder;
        public event Action<int> DelitingOrder;
        public event Action<int> ByingOrder;
        public event Action Logining;
        public event Action SiginingUp;

        public event Func<IReadOnlyList<IReadOnlyOrder>> GettingAllOrders;
        public FormPurchaser()
        {
            InitializeComponent();
        }
        public void RefreshDataGrid(IReadOnlyList<IReadOnlyOrder> data)
        {
            if (data.Count != 0)
            {
                dataGridViewOrders.DataSource = null;
                IReadOnlyOrder template = data[0];
                dataGridViewOrders.DataSource = data;

                dataGridViewOrders.Columns[nameof(template.Id)].Visible = false;
                dataGridViewOrders.Columns[nameof(template.Product)].HeaderText = "Название";
                dataGridViewOrders.Columns[nameof(template.ProductCount)].HeaderText = "Кол - во";
                dataGridViewOrders.Columns[nameof(template.ProductCount)].Width = 70;
                dataGridViewOrders.Columns[nameof(template.IsPaid)].HeaderText = "Оплачен";
                dataGridViewOrders.Columns[nameof(template.IsPaid)].Width = 60;
            }
            else
            {
                dataGridViewOrders.DataSource = null;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonToOrder_Click(object sender, EventArgs e)
        {
            AddingOrder?.Invoke(textBoxProduct.Text, int.Parse(numericUpDownProductCount.Text), int.Parse(textBoxProductPrice.Text));
            textBoxProduct.Text = null;
            numericUpDownProductCount.Text = null;
            textBoxProductPrice.Text = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            RefreshOrderData();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            UpdatingOrder?.Invoke(dataGridViewOrders.SelectedCells[0].RowIndex, textBoxProduct.Text, int.Parse(numericUpDownProductCount.Text), int.Parse(textBoxProductPrice.Text));
            textBoxProduct.Text = null;
            numericUpDownProductCount.Text = null;
            textBoxProductPrice.Text = null;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            DelitingOrder?.Invoke(dataGridViewOrders.SelectedCells[0].RowIndex);
        }

        public void RefreshOrderData()
        {
            IReadOnlyList<IReadOnlyOrder> data = GettingAllOrders?.Invoke();
            RefreshDataGrid(data);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Logining?.Invoke();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SiginingUp?.Invoke();
        }

        private void FormPurchaser_Load(object sender, EventArgs e)
        {

        }

        public void EnableFormFromPurchaser()
        {
            textBoxProduct.Visible = true;
            textBoxProductPrice.Visible = true;
            labelAvaibleOrders.Visible = true;
            labelProduct.Visible = true;
            labelProductCount.Visible = true;
            labelProductPrice.Visible = true;
            numericUpDownProductCount.Visible = true;
            buttonDeleteOrder.Visible = true;
            buttonToOrder.Visible = true;
            buttonUpdate.Visible = true;
            buttonUpdateOrder.Visible = true;
            dataGridViewOrders.Visible = true;
            buttonSignIn.Visible = false;
            buttonSignUp.Visible = false;
            label1.Visible = false;
            buttonSell.Visible = false;
        }
        public void EnableFormFromSupplier()
        {
            label1.Visible = true;
            dataGridViewOrders.Visible = true;
            buttonSell.Visible = true;
            buttonSignIn.Visible = false;
            buttonSignUp.Visible = false;
            buttonUpdate.Visible = true;
            textBoxProduct.Visible = false;
            textBoxProductPrice.Visible = false;
            labelAvaibleOrders.Visible = false;
            labelProduct.Visible = false;
            labelProductCount.Visible = false;
            labelProductPrice.Visible = false;
            numericUpDownProductCount.Visible = false;
            buttonDeleteOrder.Visible = false;
            buttonToOrder.Visible = false;
            buttonUpdateOrder.Visible = false;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            ByingOrder?.Invoke(dataGridViewOrders.SelectedCells[0].RowIndex);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
