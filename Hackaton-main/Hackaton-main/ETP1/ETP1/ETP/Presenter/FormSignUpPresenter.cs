using ETP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ETP.Model.Order;

namespace ETP.Presenter
{
    class FormSignUpPresenter
    {
        private PlatformData _model;
        private FormSignUp _view;

        public FormSignUpPresenter(PlatformData model, FormSignUp view)
        {
            _model = model;
            _view = view;

            //_view.Sigining += OnSigining;
        }

        //private void OnSigining(string name, string password, string fName, string sName, string tName, string mail, string phoneNumber) => _model.(name, password, fName, sName, tName, mail, phoneNumber);
    }
}
