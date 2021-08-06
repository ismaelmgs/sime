using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using NucleoBase.Core;
using SIME.Clases;

namespace SIME.DomainModel
{
    public class DBMisSolicitudes : DBBase
    {
        public DataTable DBGetObtieneMisSolicitudesAVisualizar()
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_ObtieneMisSolicitudesAVisualizar]", "@IdPerfil", Utils.GetPerfilUsuario,
                                                                                        "@IdUsuario", Utils.GetIdProveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DBGetObtieneDetalleSolicitud(int iIdSolicitd)
        {
            try
            {
                return oDB_SP.EjecutarDS("[dbo].[spS_ObtieneDetalleSolicitud]", "@IdSolicitud", iIdSolicitd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DBGetObtieneListaProveedores()
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_ConsultaProveedores]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetActualizaProveedorEnSolicitud(int iIdSolicitud, int iIdProveedor)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spU_ActalizaProveedorEnSolicitud]", "@IdSolicitud", iIdSolicitud,
                                                                                                "@ProveedorAsignado", iIdProveedor,
                                                                                                "@UsuarioModificacion", Utils.GetNombreUsuario);

                return oRes.S().I();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}