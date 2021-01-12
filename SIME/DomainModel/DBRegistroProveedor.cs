using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SIME.DomainModel
{
    public class DBRegistroProveedor : DBBase
    {
        public DataTable DBInsertaProveedor(Registro oRegistro)
        {
            try
            {
                return oDB_SP.EjecutarDT("[sp_Inserta_Proveedores]"
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
                                                , "@Fecha_Registro", oRegistro.Fecha_Registro
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
    }
}