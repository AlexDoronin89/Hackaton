using ETP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Presenter
{
    internal class FormSupplierPresentor
    {
        private FormSupplier _view;
        private PlatformData _model;

        public FormSupplierPresentor(FormSupplier view, PlatformData model)
        {
            _view = view;
            _model = model;


            //_model.AddingOrder += OnAddingOrder;

        }


        //private void OnAddingOrder() => _view()


    }
}
