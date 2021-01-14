using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.Interfaces
{
    public interface IMasterView : IBaseView
    {
        int iPerfil { set; get; }

        void LoadMenu(DataTable dt);

        event EventHandler eSearchMenu;
    }
}