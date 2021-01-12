using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class ConsultaClientePresenter : BasePresenter<IConsultaClienteView>
    {
        private readonly DBConsultaCliente oIGestCat;

        public ConsultaClientePresenter(IConsultaClienteView oView, DBConsultaCliente oGC)
            : base(oView)
        {
            oIGestCat = oGC;
            oIView.eSearchCiletes += SearchCiletes_Presenter;
        }

        private void SearchCiletes_Presenter(object sender, EventArgs e)
        {
            oIView.LoadCiletes(oIGestCat.DBObtieneCliente(oIView.sBusctar));
        }
    }
}