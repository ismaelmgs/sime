using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.DomainModel
{
    public class DBLogin : DBBase
    {
        public DataTable DBObtieneUsuario(string sUsuario, string sPass)
        {
            try
            {
                return oDB_SP.EjecutarDT("sp_seg_Login", "@Usuario", sUsuario, "@Pass", sPass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}