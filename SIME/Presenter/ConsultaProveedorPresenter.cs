using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class ConsultaProveedorPresenter: BasePresenter<IConsultaProveedorView>
    {
        private readonly DBConsultaProveedor oIGestCat;

        public ConsultaProveedorPresenter(IConsultaProveedorView oView, DBConsultaProveedor oGC)
            : base(oView)
        {
            oIGestCat = oGC;
            oIView.eSearchProveedores += SearchProveedores_Presenter;
        }

        private void SearchProveedores_Presenter(object sender, EventArgs e)
        {
            oIView.LoadProveedores(oIGestCat.DBObtieneProveedor(oIView.sBusctar));
        }
    }
}