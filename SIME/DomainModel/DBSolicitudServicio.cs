using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SIME.Clases;
using NucleoBase.Core;

namespace SIME.DomainModel
{
    public class DBSolicitudServicio : DBBase
    {
        public DataTable DBGetObtieneCatalogosSolicitudServicio()
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_ConsultaCategoriasSolicitud]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DBGetObtieneSubcategoriaSolicitudServicio(int iIdCategoria)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_ConsultaSubcategoriasSolicitud]", "@IdCategoria", iIdCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetInsertaSolicitudServicio(SolicitudServicio oSer)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spI_InsertaSolicitudServicio]", "@Descripcion", oSer.sDescripcion,
                                                                                            "@UsuarioCreacion", Utils.GetNombreUsuario);

                int iSol = oRes.S().I();

                DBSetInsertaCategoriasSolicitudServicio(oSer.oLstCat, iSol);
                DBSetInsertaImagenesSolicitudServicio(oSer.oLstFotos, iSol);

                return iSol;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetInsertaCategoriasSolicitudServicio(List<CategoriaServ> olstCat, int iIdSolicitud)
        {
            try
            {
                int iSol = 0;
                foreach (CategoriaServ oCat in olstCat)
                {
                    object oRes = oDB_SP.EjecutarValor("[dbo].[spI_InsertaCategoriasSubcategoriasSolicitud]", "@IdSolicitud", iIdSolicitud,
                                                                                                                "@IdCategoria", oCat.iIdCategoria,
                                                                                                                "@IdSubcategoria", oCat.iIdSubcategoria);

                    iSol = oRes.S().I();
                }

                return iSol;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetInsertaImagenesSolicitudServicio(List<Fotografia> oLstFotos, int iIdSolicitud)
        {
            try
            {
                int iSol = 0;
                foreach (Fotografia oFoto in oLstFotos)
                {
                    object oRes = oDB_SP.EjecutarValor("[dbo].[spI_InsertaImagenesSolicitudServicio]", "@IdSolicitud", iIdSolicitud,
                                                                                                        "@NombreImagen", oFoto.sNombre,
                                                                                                        "@Imagen", oFoto.sFoto,
                                                                                                        "@Extension", oFoto.sExtension);

                    iSol = oRes.S().I();
                }

                return iSol;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}