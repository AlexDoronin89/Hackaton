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
    class FormTablePresenter
    {
        private PlatformData _model;
        private FormPurchaser _view;

        public FormTablePresenter(PlatformData model, FormPurchaser view)
        {
            _model = model;
            _view = view;

            _model.AddedOrder += OnAddedOrder;
            _model.RemovedOrder += OnRemovedOrder;
            _model.UpdatedOrder += OnUpdatedOrder;
            _view.AddingOrder += OnAddingOrder;
            _view.GettingAllOrders += OnGettingAllOrders;
            _view.Logining += OnOpeningSignInForm;
            _view.SiginingUp += OnOpeningSignUpFrom;
            _model.OpenedMainFormPurchaser += OnOpenedMainFormPurchaser;
            _model.OpenedMainFormSupplier += OnOpenedMainFormSupplier;
            _view.ByingOrder += OnByingOrder;
            _view.DelitingOrder += OnDelitingOrder;
            _view.UpdatingOrder += OnUpdatingOrder;
        }

        private void OnByingOrder(int index) => _model.BuyOrder(index);
        private void OnDelitingOrder(int index) => _model.BuyOrder(index);
        private void OnUpdatingOrder(int id, string name, int productCount, int productPrice) => _model.UpdateOrder(id, name, productCount, productPrice);
        private void OnOpenedMainFormPurchaser()
        {
            FormPurchaser _view = new FormPurchaser();
            FormTablePresenter signInPresenter = new FormTablePresenter(_model, _view);
            _view.EnableFormFromPurchaser();
            _view.ShowDialog();
        }
        private void OnOpenedMainFormSupplier()
        {
            FormPurchaser _view = new FormPurchaser();
            FormTablePresenter signInPresenter = new FormTablePresenter(_model, _view);
            _view.EnableFormFromSupplier();
            _view.ShowDialog();
        }
        private void OnAddingOrder(string name, int productCount, int productPrice) => 
            _model.AddOrder(name, productCount, productPrice);
        private void OnAddedOrder() => _view.RefreshOrderData();
        private void OnRemovedOrder() => _view.RefreshOrderData();
        private void OnUpdatedOrder() => _view.RefreshOrderData();
        private IReadOnlyList<IReadOnlyOrder> OnGettingAllOrders() => _model.GetOrder();
        private void OnOpeningSignInForm()
        {
            FormSignIn view = new FormSignIn();
            FormSignInPresenter signInPresenter = new FormSignInPresenter(_model, view);
            view.ShowDialog();
        }
        private void OnOpeningSignUpFrom()
        {
            FormSignUp view = new FormSignUp();
            FormSignUpPresenter signInPresenter = new FormSignUpPresenter(_model, view);
            view.ShowDialog();
        }
    }
}
