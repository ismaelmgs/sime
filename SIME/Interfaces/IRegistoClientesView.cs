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
        int iIdCliente { set; get; }

        void MostrarMensaje(string sMensaje, string sTitulo);

        event EventHandler eInsertaClientes;
    }
}