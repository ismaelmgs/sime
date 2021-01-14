using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.DomainModel
{
    public class DBMaster : DBBase
    {
        public DataTable DBObtieneMenu(int iPerfil)
        {
            try
            {
                return oDB_SP.EjecutarDT("sp_seg_Menu", "@IDPerfil", iPerfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}