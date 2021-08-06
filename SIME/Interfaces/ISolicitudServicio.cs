using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME.Interfaces
{
    public interface ISolicitudServicio : IBaseView
    {
        int iIdCategoria { get; }
        SolicitudServicio oServ { set; get; }

        void MostrarMensaje(string sMensaje, string sTitulo);
        void LoadCatalogos(DataTable dt);
        void LoadSubCategoria(DataTable dt);


        event EventHandler eGetSubCategorias;
    }
}
