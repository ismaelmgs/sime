using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Objetos
{
    [Serializable]
    public class SolicitudServicio
    {
        private List<CategoriaServ> _oLstCat = new List<CategoriaServ>();
        private string _sDescripcion = string.Empty;
        private List<Fotografia> _oLstFotos;

        public List<CategoriaServ> oLstCat { set { _oLstCat = value; } get { return _oLstCat; } }
        public string sDescripcion { set { _sDescripcion = value; } get { return _sDescripcion; } }
        public List<Fotografia> oLstFotos { set { _oLstFotos = value; } get { return _oLstFotos; } }
    }

    public class CategoriaServ
    {
        private int _iIdSolicitud = 0;
        private int _iIdCategoria = 0;
        private int _iIdSubcategoria = 0;

        public int iIdSolicitud { set { _iIdSolicitud = value; } get { return _iIdSolicitud; } }
        public int iIdCategoria { set { _iIdCategoria = value; } get { return _iIdCategoria; } }
        public int iIdSubcategoria { set { _iIdSubcategoria = value; } get { return _iIdSubcategoria; } }
    }
}