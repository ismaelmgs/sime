using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME.Interfaces
{
    public interface IPerfil : IBaseView
    {
        int iIdPerfil { get; set; }
        Perfil oPer { get; }

        void LoadPerfiles(DataTable dt);
        void MostrarMensaje(string sMensaje, string sTitulo);


    }
}
