using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.DomainModel
{
    public class DBConsultaProveedor : DBBase
    {
        public DataTable DBObtieneProveedor(string Buscar)
        {
            try
            {
                return oDB_SP.EjecutarDT("[sp_Consulta_Proveedores]", "@Buscar", Buscar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}