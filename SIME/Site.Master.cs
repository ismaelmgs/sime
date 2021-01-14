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
using SIME.Clases;

namespace SIME
{
    public partial class Site : System.Web.UI.MasterPage, IMasterView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserIdentity"] == null)
                    Response.Redirect("../Views/frmLogin.aspx");

                oPreseneter = new MasterPresenter(this, new DBMaster());
                if (!IsPostBack)
                {
                    iPerfil = Utils.GetPerfilUsuario;

                    if (eSearchMenu != null)
                        eSearchMenu(sender, e);
                }
            }
            catch (Exception)
            {
                alert("Error de conexión");
            }
        }

        #region MÉTODOS

        private void alert(string m)
        {
            m = "alert('" + m + "');";
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "alert", m, true);
        }

        public void LoadMenu(DataTable dt)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                     Menu(MenuUsuarios.Items, 0, dt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Menu(MenuItemCollection items, int idpadre, DataTable dt)
        {
            int id;
            string NombreMenu = string.Empty;

            try
            {
                // filtramos por el id que toma este, el primero es "0" que son los padres
                DataRow[] hijos = dt.Select("ID_ItemPadre=" + idpadre.ToString());

                // validamos que encontremos resultados, si no volvemos    
                if (hijos.Length == 0)
                    return;
                // recorremos la informacion 

                foreach (DataRow hijo in hijos)
                {
                    // asignamos las variables al menu
                    id = Convert.ToInt32(hijo[0]);

                    MenuItem nuevoItem = new MenuItem(NombreMenu, id.ToString());
                    nuevoItem.NavigateUrl = hijo["Des_URL"].ToString().Trim();

                    items.Add(nuevoItem);
                    // llamamos a la funcion nuevamente para que revise si tiene mas informacion asociada
                    Menu(nuevoItem.ChildItems, id, dt);
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region VARIABLES Y PROPIEDADES

        MasterPresenter oPreseneter;
        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;

        public event EventHandler eSearchMenu;

        public int iPerfil { get { return (int)ViewState["VSPerfil"]; } set { ViewState["VSPerfil"] = value; } }

        #endregion
    }
}