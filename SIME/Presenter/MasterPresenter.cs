using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class MasterPresenter : BasePresenter<IMasterView>
    {
        private readonly DBMaster oIGestCat;

        public MasterPresenter(IMasterView oView, DBMaster oGC)
            : base(oView)
        {
            oIGestCat = oGC;
            oIView.eSearchMenu += SearchUsuario_Presenter;
        }

        private void SearchUsuario_Presenter(object sender, EventArgs e)
        {
            oIView.LoadMenu(oIGestCat.DBObtieneMenu(oIView.iPerfil));
        }
    }
}