using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class RegistroProveedorPresenter : BasePresenter<IRegistroProveedorView>
    {
        private readonly DBRegistroProveedor oIGestCat;

        public RegistroProveedorPresenter(IRegistroProveedorView oView, DBRegistroProveedor oGC)
            : base(oView)
        {
            oIGestCat = oGC;
            oIView.eInsertaProveedor += InsertaProveedor_Presenter;
        }

        private void InsertaProveedor_Presenter(object sender, EventArgs e)
        {
            oIView.MostrarMensaje(oIGestCat.DBInsertaProveedor(oIView.oRegistro));
        }
    }
}