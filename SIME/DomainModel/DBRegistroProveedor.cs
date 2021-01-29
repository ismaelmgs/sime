using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using NucleoBase.Core;

namespace SIME.DomainModel
{
    public class DBRegistroProveedor : DBBase
    {
        public DataTable DBInsertaProveedor(Registro oRegistro)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[sp_Inserta_Proveedores]"
                                                , "@Id_Tipo_Persona", oRegistro.Id_Tipo_Persona
                                                , "@Razon_Social", oRegistro.Razon_Social
                                                , "@Sector", oRegistro.Sector
                                                , "@Primer_Nombre", oRegistro.Primer_Nombre
                                                , "@Segundo_Nombre", oRegistro.Segundo_Nombre
                                                , "@App_Pat", oRegistro.App_Pat
                                                , "@App_Mat", oRegistro.App_Mat
                                                , "@RFC", oRegistro.RFC
                                                , "@Calle", oRegistro.Calle
                                                , "@Num_Ext", oRegistro.Num_Ext
                                                , "@Num_Int", oRegistro.Num_Int
                                                , "@CP", oRegistro.CP
                                                , "@Colonia", oRegistro.Colonia
                                                , "@Mpio_Del", oRegistro.Mpio_Del
                                                , "@Ciudad", oRegistro.Ciudad
                                                , "@Pais", oRegistro.Pais
                                                , "@Fec_Nac", oRegistro.Fec_Nac
                                                , "@Identificacion", oRegistro.Identificacion
                                                , "@Id_Status", oRegistro.Id_Status
                                                , "@Usuario_Registro", oRegistro.Usuario_Registro
                                                , "@Contacto_Servicios", oRegistro.Contacto_Servicios
                                                , "@Tel_Cont_serv", oRegistro.Tel_Cont_serv
                                                , "@Mail_Cont_serv", oRegistro.Mail_Cont_serv
                                                , "@Contacto_Administrativo", oRegistro.Contacto_Administrativo
                                                , "@Tel_Cont_adm", oRegistro.Tel_Cont_adm
                                                , "@Mail_Cont_adm", oRegistro.Mail_Cont_adm
                    );
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Columna1", typeof(int));
                dt.Columns.Add("Columna2");

                DataRow row = dt.NewRow();
                row["Columna1"] = 0;
                row["Columna2"] = ex.Message;

                dt.Rows.Add(row);

                return dt;
            }
        }

        public Registro DBGetObtieneProveedoresPorId(int iIdCliente)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_ConsultaProveedorPorId]", "@Id_Prov", iIdCliente).AsEnumerable().Select(r => new Registro()
                                                                                            {
                                                                                                Id_Tipo_Persona = r["IDTipoPersona"].S().I(),
                                                                                                Razon_Social = r["Razon_Social"].S(),
                                                                                                Sector = r["Sector"].S(),
                                                                                                Primer_Nombre = r["Primer_Nombre"].S(),
                                                                                                Segundo_Nombre = r["Segundo_Nombre"].S(),
                                                                                                App_Pat = r["App_Pat"].S(),
                                                                                                App_Mat = r["App_Mat"].S(),
                                                                                                RFC = r["RFC"].S(),
                                                                                                Calle = r["Calle"].S(),
                                                                                                Num_Ext = r["Num_Ext"].S(),
                                                                                                Num_Int = r["Num_Int"].S(),
                                                                                                CP = r["CP"].S(),
                                                                                                Colonia = r["Colonia"].S(),
                                                                                                Mpio_Del = r["Mpio_Del"].S(),
                                                                                                Ciudad = r["Ciudad"].S(),
                                                                                                Pais = r["Pais"].S(),
                                                                                                Fec_Nac = r["Fec_Nac"].S().Dt(),
                                                                                                Identificacion = r["Identificacion"].S(),
                                                                                                Id_Status = r["Id_Status"].S().I(),
                                                                                                Usuario_Registro = r["Usuario_Registro"].S(),
                                                                                                Contacto_Servicios = r["Contacto_Servicios"].S(),
                                                                                                Tel_Cont_serv = r["Tel_Cont_serv"].S(),
                                                                                                Mail_Cont_serv = r["Mail_Cont_serv"].S(),
                                                                                                Contacto_Administrativo = r["Contacto_Administrativo"].S(),
                                                                                                Tel_Cont_adm = r["Tel_Cont_adm"].S(),
                                                                                                Mail_Cont_adm = r["Mail_Cont_adm"].S()
                                                                                            }).First();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DBSetActualizaProveedorPersonaFisica(Registro oRegistro)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spU_ActualizaProveedorPersonaFisica]", "@Id_Prov", oRegistro.iIdProveedor,
                                                                                                "@Primer_Nombre", oRegistro.Primer_Nombre,
                                                                                                "@Segundo_Nombre", oRegistro.Segundo_Nombre,
                                                                                                "@App_Pat", oRegistro.App_Pat,
                                                                                                "@App_Mat", oRegistro.App_Mat,
                                                                                                "@RFC", oRegistro.RFC,
                                                                                                "@Sector", oRegistro.Sector,
                                                                                                "@Calle", oRegistro.Calle,
                                                                                                "@Num_Ext", oRegistro.Num_Ext,
                                                                                                "@Num_Int", oRegistro.Num_Int,
                                                                                                "@CP", oRegistro.CP,
                                                                                                "@Colonia", oRegistro.Colonia,
                                                                                                "@Mpio_Del", oRegistro.Mpio_Del,
                                                                                                "@Ciudad", oRegistro.Ciudad,
                                                                                                "@Pais", oRegistro.Pais,
                                                                                                "@Fec_Nac", oRegistro.Fec_Nac,
                                                                                                "@Identificacion", oRegistro.Identificacion,
                                                                                                "@Contacto_Servicios", oRegistro.Contacto_Servicios,
                                                                                                "@Tel_Cont_serv", oRegistro.Tel_Cont_serv,
                                                                                                "@Mail_Cont_serv", oRegistro.Mail_Cont_serv,
                                                                                                "@Contacto_Administrativo", oRegistro.Contacto_Administrativo,
                                                                                                "@Tel_Cont_adm", oRegistro.Tel_Cont_adm,
                                                                                                "@Mail_Cont_adm", oRegistro.Mail_Cont_adm,
                                                                                                "@Usuario_Modifica", oRegistro.Usuario_Registro,
                                                                                                "@Comentarios", string.Empty);

                return oRes.S().I() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DBSetActualizaProveedorPersonaMoral(Registro oRegistro)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spU_ActualizaProveedorPersonaMoral]", "@Id_Prov", oRegistro.iIdProveedor,
                                                                                                "@Razon_Social", oRegistro.Razon_Social,
                                                                                                "@RFC", oRegistro.RFC,
                                                                                                "@Sector", oRegistro.Sector,
                                                                                                "@Calle", oRegistro.Calle,
                                                                                                "@Num_Ext", oRegistro.Num_Ext,
                                                                                                "@Num_Int", oRegistro.Num_Int,
                                                                                                "@CP", oRegistro.CP,
                                                                                                "@Colonia", oRegistro.Colonia,
                                                                                                "@Mpio_Del", oRegistro.Mpio_Del,
                                                                                                "@Ciudad", oRegistro.Ciudad,
                                                                                                "@Pais", oRegistro.Pais,
                                                                                                "@Contacto_Servicios", oRegistro.Contacto_Servicios,
                                                                                                "@Tel_Cont_serv", oRegistro.Tel_Cont_serv,
                                                                                                "@Mail_Cont_serv", oRegistro.Mail_Cont_serv,
                                                                                                "@Contacto_Administrativo", oRegistro.Contacto_Administrativo,
                                                                                                "@Tel_Cont_adm", oRegistro.Tel_Cont_adm,
                                                                                                "@Mail_Cont_adm", oRegistro.Mail_Cont_adm,
                                                                                                "@Usuario_Modifica", oRegistro.Usuario_Registro,
                                                                                                "@Comentarios", string.Empty);

                return oRes.S().I() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}