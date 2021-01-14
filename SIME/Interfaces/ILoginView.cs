using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.Interfaces
{
    public interface ILoginView : IBaseView
    {
        UserIdentity oUsuario { set; get; }

        string sUsuario { set; get; }
        string sPass { set; get; }

        void LoadUsuario(DataTable dt);

        event EventHandler eSearchUsuario;
    }
}