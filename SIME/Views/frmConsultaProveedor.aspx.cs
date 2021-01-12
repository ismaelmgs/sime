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

namespace SIME.Views
{
    public partial class frmConsultaProveedor : System.Web.UI.Page , IConsultaProveedorView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new ConsultaProveedorPresenter(this, new DBConsultaProveedor());

            if (!IsPostBack)
            {
                sBusctar = string.Empty;
                if (eSearchProveedores != null)
                    eSearchProveedores(sender, e);
            }
        }

        protected void btnBucar_Click(object sender, EventArgs e)
        {
            sBusctar = txtBuscar.Text;
            if (eSearchProveedores != null)
                eSearchProveedores(sender, e);
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

        public string sBusctar
        {
            set { ViewState["VSsBusctar"] = value; }
            get { return (string)ViewState["VSsBusctar"]; }
        }

        #endregion
    }
}