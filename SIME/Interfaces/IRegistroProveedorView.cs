using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.Interfaces
{
    public interface IRegistroProveedorView : IBaseView
    {
        Registro oRegistro { set; get; }
        int iIdProveedor { set; get; }


        void MostrarMensaje(string sMensaje, string sTitulo);


        event EventHandler eInsertaProveedor;
    }
}