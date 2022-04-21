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
        public event Action<string, string, string, string, string, string, string> Sigining;
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSiginingUp_Click(object sender, EventArgs e)
        {
            Sigining?.Invoke(textBoxLogin.Text, textBoxPassword.Text, textBoxFirstName.Text, textBoxSurname.Text, textBoxSecondName.Text, textBoxEmail.Text, maskedTextBoxPhoneNumber.Text);
            textBoxLogin.Text = null;
            textBoxPassword.Text = null;
            textBoxFirstName.Text = null;
            textBoxSurname.Text = null;
            textBoxSecondName.Text = null;
            textBoxEmail.Text = null;
            maskedTextBoxPhoneNumber.Text = null;
        }
    }
}
