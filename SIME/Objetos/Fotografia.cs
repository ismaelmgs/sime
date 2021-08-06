using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Objetos
{
    [Serializable]
    public class Fotografia
    {
        private string _sNombre = string.Empty;
        private string _sExtension = string.Empty;
        private string _sFoto;

        public string sNombre { set { _sNombre = value; } get { return _sNombre; } }
        public string sExtension { set { _sExtension = value; } get { return _sExtension; } }
        public string sFoto { set { _sFoto = value; } get { return _sFoto; } }
    }
}