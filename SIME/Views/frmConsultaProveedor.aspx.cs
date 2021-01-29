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
using SIME.Clases;

namespace SIME.Views
{
    public partial class frmConsultaProveedor : System.Web.UI.Page , IConsultaProveedorView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new ConsultaProveedorPresenter(this, new DBConsultaProveedor());

            if (eSearchProveedores != null)
                eSearchProveedores(sender, e);

            if (!IsPostBack)
            {
                sBusctar = string.Empty;
            }
        }

        protected void btnBucar_Click(object sender, EventArgs e)
        {
            //sBusctar = txtBuscar.Text;
            //if (eSearchProveedores != null)
            //    eSearchProveedores(sender, e);
        }

        protected void gvProveedores_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            string sOpcion = ((DevExpress.Web.ASPxButton)e.CommandSource).CommandName.S();
            iIdProveedor = e.CommandArgs.CommandArgument.S().I();

            object cellValues = gvProveedores.GetRowValuesByKeyValue(iIdProveedor, "Proveedor" //0
                                                                                , "Descripcion" //1
                                                                                , "RFC" //2
                                                                                , "Contacto_Serv" //3
                                                                                , "Contacto_Admin" //4
                                                                                , "Sector" //5
            );

            if (sOpcion == "Proveedor")
            {
                string sCli = Utils.EncodeStrToBase64(iIdProveedor.S());
                Response.Redirect("frmRegistroProveedor.aspx?IdPro=" + sCli);
            }
        }

        #region MÉTODOS

        public void LoadProveedores(DataTable dt)
        {
            try
            {
                gvProveedores.DataSource = dt;
                gvProveedores.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region VARIABLES Y PROPIEDADES

        ConsultaProveedorPresenter oPresenter;

        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;

        public event EventHandler eSearchProveedores;

        public int iIdProveedor
        {
            set { ViewState["VSiIdProveedor"] = value; }
            get { return (int)ViewState["VSiIdProveedor"]; }
        }

        public string sBusctar
        {
            set { ViewState["VSsBusctar"] = value; }
            get { return (string)ViewState["VSsBusctar"]; }
        }

        #endregion

        
    }
}