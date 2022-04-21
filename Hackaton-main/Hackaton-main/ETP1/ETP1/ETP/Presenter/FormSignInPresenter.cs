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
    class FormSignInPresenter
    {
        private PlatformData _model;
        private FormSignIn _view;

        public FormSignInPresenter(PlatformData model, FormSignIn view)
        {
            _model = model;
            _view = view;

            //_view.Logining += OnLogining;
            _view.Signing += OnSigning;
        }

        //private void OnLogining(string name, string password) => _model.(name, password);
        private void OnSigning()
        {
            FormSignUp view = new FormSignUp();
            FormSignUpPresenter formSignUpPresenter = new FormSignUpPresenter(_model, view);
            view.ShowDialog();
        }
    }
}
