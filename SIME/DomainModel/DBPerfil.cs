using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SIME.Clases;
using NucleoBase.Core;
using SIME.Objetos;

namespace SIME.DomainModel
{
    public class DBPerfil : DBBase
    {
        public DataTable DBGetObtienePerfiles()
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_ConsultaPerfiles]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DBSetInsertaPerfil(Perfil oPer)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spI_InsertaPerfil]", "@Des_Perfil", oPer.sDescPerfil,
                                                                                "@Comentarios", oPer.sComentarios,
                                                                                "@Usuario_Registro", Utils.GetNombreUsuario);

                return oRes.S().I() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DBSetActualizaPerfil(Perfil oPer)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spU_ActualizaPerfil]", "@ID_Perfil", oPer.iIdPerfil,
                                                                                    "@Des_Perfil", oPer.sDescPerfil,
                                                                                    "@Usuario_Modifica", Utils.GetNombreUsuario,
                                                                                    "@Comentarios", oPer.sComentarios);

                return oRes.S().I() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DBSetInactivaPerfil(int iIdPerfil)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spU_InactivaPerfil]", "@ID_Perfil", iIdPerfil,
                                                                                "@Usuario_Modifica", Utils.GetNombreUsuario);

                return oRes.S().I() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}