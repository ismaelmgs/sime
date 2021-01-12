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
    public partial class frmConsultaCliente : System.Web.UI.Page, IConsultaClienteView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new ConsultaClientePresenter(this, new DBConsultaCliente());

            if (!IsPostBack)
            {
                sBusctar = string.Empty;
                if (eSearchCiletes != null)
                    eSearchCiletes(sender, e);
            }

        }

        protected void btnBucar_Click(object sender, EventArgs e)
        {
            sBusctar = txtBuscar.Text;
            if (eSearchCiletes != null)
                eSearchCiletes(sender, e);
        }

        #region MÉTODOS

        public void LoadCiletes(DataTable dt)
        {
            try
            {
                gvClientes.DataSource = dt;
                gvClientes.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region VARIABLES Y PROPIEDADES

        ConsultaClientePresenter oPresenter;

        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;

        public event EventHandler eSearchCiletes;

        public string sBusctar
        {
            set { ViewState["VSsBusctar"] = value; }
            get { return (string)ViewState["VSsBusctar"]; }
        }

        #endregion

    }
}