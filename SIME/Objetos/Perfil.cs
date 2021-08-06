using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Objetos
{
    public class Perfil
    {
        private int _iIdPerfil = 0;
        private string _sDescPerfil = string.Empty;
        private string _sComentarios = string.Empty;

        public int iIdPerfil { set { _iIdPerfil = value; } get { return _iIdPerfil; } }
        public string sDescPerfil { set { _sDescPerfil = value; } get { return _sDescPerfil; } }
        public string sComentarios { set { _sComentarios = value; } get { return _sComentarios; } }
    }
}