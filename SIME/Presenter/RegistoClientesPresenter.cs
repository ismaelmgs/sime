using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            oIView.MostrarMensaje(oIGestCat.DBInsertaCliente(oIView.oRegistro));
        }
    }
}