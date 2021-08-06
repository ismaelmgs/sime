using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class MisSolicitudes_Presenter : BasePresenter<IMisSolicitudes>
    {
        private readonly DBMisSolicitudes oIGestCat;

        public MisSolicitudes_Presenter(IMisSolicitudes oView, DBMisSolicitudes oGC)
            : base(oView)
        {
            oIGestCat = oGC;

            oIView.eGetProveedor += eGetProveedor_Presenter;
            oIView.eUpdProveedor += eUpdProveedor_Presenter;
        }

        protected override void SearchObj_Presenter(object sender, EventArgs e)
        {
            oIView.CargaMisSolicitudes(oIGestCat.DBGetObtieneMisSolicitudesAVisualizar());
        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.dsImagenes = oIGestCat.DBGetObtieneDetalleSolicitud(oIView.iIdSolicitud);
            oIView.CargaImagenesModal();
        }

        protected void eGetProveedor_Presenter(object sender, EventArgs e)
        {
            oIView.dtProveedores = oIGestCat.DBGetObtieneListaProveedores();
        }

        protected void eUpdProveedor_Presenter(object sender, EventArgs e)
        {
            if (oIGestCat.DBSetActualizaProveedorEnSolicitud(oIView.iIdSolicitud, oIView.iIdProveedor) > 0)
            {
                oIView.CargaMisSolicitudes(oIGestCat.DBGetObtieneMisSolicitudesAVisualizar());
            }
        }
    }
}