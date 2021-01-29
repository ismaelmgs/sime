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
    public class RegistoClientesPresenter : BasePresenter<IRegistoClientesView>
    {
        private readonly DBRegistoClientes oIGestCat;

        public RegistoClientesPresenter(IRegistoClientesView oView, DBRegistoClientes oGC)
            : base(oView)
        {
            oIGestCat = oGC;
            oIView.eInsertaClientes += InsertaClientes_Presenter;
        }

        private void InsertaClientes_Presenter(object sender, EventArgs e)
        {
            DataTable dt = oIGestCat.DBInsertaCliente(oIView.oRegistro);
            oIView.MostrarMensaje(dt.Rows[0][0].S(), "Aviso");
        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.oRegistro = oIGestCat.DBGetObtieneClientePorId(oIView.iIdCliente);
        }

        protected override void SaveObj_Presenter(object sender, EventArgs e)
        {
            Registro oReg = oIView.oRegistro;
            if (oReg.Id_Tipo_Persona == 1)
            {
                bool ban = oIGestCat.DBSetActualizaClientePersonaFisica(oReg);
                if (ban)
                    oIView.MostrarMensaje("El cliente se actualizó con exito.", "Aviso");
            }
            else if (oReg.Id_Tipo_Persona == 2)
            {
                bool ban = oIGestCat.DBSetActualizaClientePersonaMoral(oReg);
                if (ban)
                    oIView.MostrarMensaje("El cliente se actualizó con exito.", "Aviso");
            }
        }
    }
}