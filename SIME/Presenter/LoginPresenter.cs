using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly DBLogin oIGestCat;

        public LoginPresenter(ILoginView oView, DBLogin oGC)
            : base(oView)
        {
            oIGestCat = oGC;
            oIView.eSearchUsuario += SearchUsuario_Presenter;
        }

        private void SearchUsuario_Presenter(object sender, EventArgs e)
        {
            oIView.LoadUsuario(oIGestCat.DBObtieneUsuario(oIView.sUsuario, oIView.sPass));
        }
    }
}