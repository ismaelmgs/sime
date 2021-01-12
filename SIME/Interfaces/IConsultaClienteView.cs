using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.Interfaces
{
    public interface IConsultaClienteView : IBaseView
    {
        string sBusctar { set; get; }

        void LoadCiletes(DataTable dt);

        event EventHandler eSearchCiletes;
    }
}