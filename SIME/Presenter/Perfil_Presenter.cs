using SIME.DomainModel;
using SIME.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Presenter
{
    public class Perfil_Presenter : BasePresenter<IPerfil>
    {
        private readonly DBPerfil oIGestCat;

        public Perfil_Presenter(IPerfil oView, DBPerfil oGC)
            : base(oView)
        {
            oIGestCat = oGC;

        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.LoadPerfiles(oIGestCat.DBGetObtienePerfiles());
        }

        protected override void NewObj_Presenter(object sender, EventArgs e)
        {
            if (!oIGestCat.DBSetInsertaPerfil(oIView.oPer))
                oIView.MostrarMensaje("Ocurrió un error al insertar", "Aviso");
        }

        protected override void SaveObj_Presenter(object sender, EventArgs e)
        {
            if (!oIGestCat.DBSetActualizaPerfil(oIView.oPer))
                oIView.MostrarMensaje("Ocurrió un error al actualizar", "Aviso");
        }

        protected override void DeleteObj_Presenter(object sender, EventArgs e)
        {
            oIGestCat.DBSetInactivaPerfil(oIView.iIdPerfil);
        }
    }
}