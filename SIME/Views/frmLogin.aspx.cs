using SIME.DomainModel;
using SIME.Interfaces;
using SIME.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NucleoBase.Core;
using SIME.Objetos;

namespace SIME.Views
{
    public partial class frmLogin : System.Web.UI.Page, ILoginView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new LoginPresenter(this, new DBLogin());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.S() == string.Empty)
                ucMensaje.ShowMessage("El Usuario es requerido", "Aviso");
            else if (txtPassword.Text.S() == string.Empty)
                ucMensaje.ShowMessage("La contraseña es requerida", "Aviso");
            {
                sUsuario = txtUsuario.Text;
                sPass = txtPassword.Text;

                if (eSearchUsuario != null)
                    eSearchUsuario(sender, e);
            }
        }


        #region MÉTODOS

        public void LoadUsuario(DataTable dt)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    oUsuario = new UserIdentity();

                    oUsuario.sIdEmp = dt.Rows[0][0].S();
                    oUsuario.sNombre = dt.Rows[0][1].S() + " " + dt.Rows[0][2].S() + " " + dt.Rows[0][3].S();
                    oUsuario.sCorreoE = dt.Rows[0][4].S();
                    oUsuario.iPerfil = dt.Rows[0][5].I();
                    oUsuario.sPass = sPass;

                    Session["UserIdentity"] = oUsuario;

                    string sFinal = string.Empty;
                    sFinal = "../frmDefault.aspx";
                    Response.Redirect(sFinal);
                }
                else
                    MostrarMensaje("Usuario o Contraseña Incorrecto");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            try
            {
                //ucMensaje.ShowMessage(mensaje, "¡Informacion!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region VARIABLES Y PROPIEDADES

        LoginPresenter oPresenter;

        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;

        public event EventHandler eSearchUsuario;

        public string sUsuario
        {
            set { ViewState["VSsUsuario"] = value; }
            get { return (string)ViewState["VSsUsuario"]; }
        }

        public string sPass
        {
            set { ViewState["VSsPass"] = value; }
            get { return (string)ViewState["VSsPass"]; }
        }

        public UserIdentity oUsuario
        {
            get { return (UserIdentity)ViewState["VSUsuario"]; }
            set { ViewState["VSUsuario"] = value; }
        }

        #endregion
    }
}