using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.Interfaces
{
    public interface IConsultaProveedorView : IBaseView
    {
        string sBusctar { set; get; }

        void LoadProveedores(DataTable dt);

        event EventHandler eSearchProveedores;
    }
}