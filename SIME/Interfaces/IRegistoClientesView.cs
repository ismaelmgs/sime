using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.Interfaces
{
    public interface IRegistoClientesView : IBaseView
    {
        Registro oRegistro { set; get; }

        void MostrarMensaje(DataTable dt);

        event EventHandler eInsertaClientes;
    }
}