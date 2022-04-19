using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETP
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignIn _view = new FormSignIn();
            FormSignUp view = new FormSignUp();
            this.Hide();
            view.ShowDialog();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
