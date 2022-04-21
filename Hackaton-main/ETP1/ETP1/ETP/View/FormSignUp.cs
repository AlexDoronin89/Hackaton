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
    public partial class FormSignUp : Form
    {
        public event Action<string, string, string, string, string, string, string, bool, bool> SigniningUp;
        public event Action<bool, bool> OpenNewForm;
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSiginingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigniningUp?.Invoke(textBoxLogin.Text, textBoxPassword.Text, textBoxFirstName.Text, 
            textBoxSurname.Text, textBoxSecondName.Text, textBoxEmail.Text, 
            maskedTextBoxPhoneNumber.Text, radioButtonPurchaser.Enabled, radioButtonSupplier.Enabled);
            OpenNewForm?.Invoke(radioButtonPurchaser.Checked, radioButtonSupplier.Checked);  
        }

        private void maskedTextBoxPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
