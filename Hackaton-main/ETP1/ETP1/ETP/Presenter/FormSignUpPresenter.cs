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

            _view.SigniningUp += OnSignining;
            _view.OpenNewForm += OnOpenNewForm;
        }

        private void OnSignining(string name, string password, string firstName, 
            string secondName, string thirdName, string mail, 
            string phoneNumber, bool purchaser, bool supplier) => 
            _model.Create(name,password,firstName,
            secondName, thirdName, mail,
            phoneNumber, purchaser, supplier);
        private void OnOpenNewForm(bool pur, bool sup)
        {
            if(pur == true)
            {
                FormPurchaser _view = new FormPurchaser();
                FormTablePresenter signInPresenter = new FormTablePresenter(_model, _view);
                _view.EnableFormFromPurchaser();
                _view.ShowDialog();
            } else if(sup == true)
            {
                FormPurchaser _view = new FormPurchaser();
                FormTablePresenter signInPresenter = new FormTablePresenter(_model, _view);
                _view.EnableFormFromSupplier();
                _view.ShowDialog();
            }
        }
    }
}
