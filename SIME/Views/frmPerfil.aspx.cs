using SIME.DomainModel;
using SIME.Interfaces;
using SIME.Objetos;
using SIME.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NucleoBase.Core;

namespace SIME.Views
{
    public partial class frmPerfil : System.Web.UI.Page, IPerfil
    {
        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new Perfil_Presenter(this, new DBPerfil());

            if (!IsPostBack)
            {
                iIdPerfil = 0;

                if (eObjSelected != null)
                    eObjSelected(sender, e);
            }
        }

        protected void gvPerfiles_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            try
            {
                string sOpcion = ((DevExpress.Web.ASPxButton)e.CommandSource).CommandName.S();
                iIdPerfil = e.CommandArgs.CommandArgument.S().I();

                object cellValues = gvPerfiles.GetRowValuesByKeyValue(iIdPerfil, "Des_Perfil" //0
                                                                                , "DescStatus" //1
                                                                                , "Comentarios" //2
                );


                if (sOpcion == "Editar")
                {
                    Perfil oPerf = new Perfil();
                    oPerf.sDescPerfil = ((object[])cellValues)[0].S();
                    oPerf.sComentarios = ((object[])cellValues)[2].S();

                    oPer = oPerf;

                    ppAddPerfil.ShowOnPageLoad = true;
                }

                if (sOpcion == "Eliminar")
                {
                    if (eDeleteObj != null)
                        eDeleteObj(sender, e);

                    if (eObjSelected != null)
                        eObjSelected(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnAgregarPerfil_Click(object sender, EventArgs e)
        {
            iIdPerfil = 0;
            ppAddPerfil.ShowOnPageLoad = true;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (iIdPerfil == 0)
            {
                if (eNewObj != null)
                    eNewObj(sender, e);
            }
            else
            {
                if (eSaveObj != null)
                    eSaveObj(sender, e);
            }

            if (eObjSelected != null)
                eObjSelected(sender, e);

            ppAddPerfil.ShowOnPageLoad = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ppAddPerfil.ShowOnPageLoad = false;
        }
        #endregion



        #region METODOS
        public void LoadPerfiles(DataTable dt)
        {
            gvPerfiles.DataSource = dt;
            gvPerfiles.DataBind();
        }

        public void MostrarMensaje(string sMensaje, string sTitulo)
        {
            ucMensaje.ShowMessage(sMensaje, sTitulo);
        }
        #endregion



        #region VARIABLES Y PROPIEDADES

        Perfil_Presenter oPresenter;

        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;

        public int iIdPerfil
        {
            set { ViewState["VSIdPerfil"] = value; }
            get { return (int)ViewState["VSIdPerfil"]; }
        }

        public Perfil oPer
        {
            get
            {
                Perfil oPerf = new Perfil();
                oPerf.iIdPerfil = iIdPerfil;
                oPerf.sDescPerfil = txtPerfil.Text.S();
                oPerf.sComentarios = txtComentarios.Text.S();

                return oPerf;
            }
            set
            {
                Perfil oPerf = value;
                txtPerfil.Text = oPerf.sDescPerfil;
                txtComentarios.Text = oPerf.sComentarios;
            }
        }

        #endregion

        
    }
}