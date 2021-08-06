using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class SolicitudServicio_Presenter : BasePresenter<ISolicitudServicio>
    {
        private readonly DBSolicitudServicio oIGestCat;

        public SolicitudServicio_Presenter(ISolicitudServicio oView, DBSolicitudServicio oGC)
            : base(oView)
        {
            oIGestCat = oGC;

            oIView.eGetSubCategorias += eGetSubCategorias_Presenter;
    }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.LoadCatalogos(oIGestCat.DBGetObtieneCatalogosSolicitudServicio());
        }

        protected void eGetSubCategorias_Presenter(object sender, EventArgs e)
        {
            oIView.LoadSubCategoria(oIGestCat.DBGetObtieneSubcategoriaSolicitudServicio(oIView.iIdCategoria));
        }

        protected override void NewObj_Presenter(object sender, EventArgs e)
        {
            int iRes = oIGestCat.DBSetInsertaSolicitudServicio(oIView.oServ);
            if (iRes > 0)
                oIView.MostrarMensaje("La solicitud con folio: " + iRes.ToString() + ", se registró correctamente.", "Aviso");
        }
    }
}