using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME.Interfaces
{
    public interface IMisSolicitudes :IBaseView
    {
        int iIdSolicitud { set; get; }
        int iIdProveedor { set; get; }
        DataSet dsImagenes { set; get; }
        DataTable dtProveedores { set; get; }

        void CargaMisSolicitudes(DataTable dt);
        void CargaImagenesModal();

        event EventHandler eGetProveedor;
        event EventHandler eUpdProveedor;
    }
}
