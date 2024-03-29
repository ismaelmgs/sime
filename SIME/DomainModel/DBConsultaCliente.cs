﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.DomainModel
{
    public class DBConsultaCliente : DBBase
    {
        public DataTable DBObtieneCliente(string Buscar)
        {
            try
            {
                return oDB_SP.EjecutarDT("[sp_Consulta_Cliente]", "@Buscar", Buscar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}