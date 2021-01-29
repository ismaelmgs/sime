using SIME.DomainModel;
using SIME.Interfaces;
using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using NucleoBase.Core;

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
            DataTable dt = oIGestCat.DBInsertaProveedor(oIView.oRegistro);
            oIView.MostrarMensaje(dt.Rows[0][1].S(), "Aviso");
        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.oRegistro = oIGestCat.DBGetObtieneProveedoresPorId(oIView.iIdProveedor);
        }

        protected override void SaveObj_Presenter(object sender, EventArgs e)
        {
            Registro oReg = oIView.oRegistro;
            if (oReg.Id_Tipo_Persona == 1)
            {
                bool ban = oIGestCat.DBSetActualizaProveedorPersonaFisica(oReg);
                if (ban)
                    oIView.MostrarMensaje("El proveedor se actualizó con exito.", "Aviso");
            }
            else if (oReg.Id_Tipo_Persona == 2)
            {
                bool ban = oIGestCat.DBSetActualizaProveedorPersonaMoral(oReg);
                if (ban)
                    oIView.MostrarMensaje("El proveedor se actualizó con exito.", "Aviso");
            }
        }
    }
}