
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
        public event Action<string, string> EndLogining;

        public FormSignIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EndLogining?.Invoke(textBoxLogin.Text, textBoxPassword.Text);
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
