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
    public partial class frmConsultaCliente : System.Web.UI.Page, IConsultaClienteView
    {
        #region EVENTOS
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
            //sBusctar = txtBuscar.Text;
            //if (eSearchCiletes != null)
            //    eSearchCiletes(sender, e);
        }

        protected void gvClientes_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            string sOpcion = ((DevExpress.Web.ASPxButton)e.CommandSource).CommandName.S();
            iIdCliente = e.CommandArgs.CommandArgument.S().I();

            object cellValues = gvClientes.GetRowValuesByKeyValue(iIdCliente, "Cliente" //0
                                                                                , "Descripcion" //1
                                                                                , "RFC" //2
                                                                                , "DatosContactoServicio" //3
                                                                                , "DatosContactoAdmin" //4
                                                                                , "Sector" //5
            );

            if (sOpcion == "Cliente")
            {
                string sCli = Utils.EncodeStrToBase64(iIdCliente.S());
                Response.Redirect("frmRegistoClientes.aspx?IdCli="+ sCli);
            }
        }
        #endregion
        
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

        public int iIdCliente
        {
            set { ViewState["VSiIdCliente"] = value; }
            get { return (int)ViewState["VSiIdCliente"]; }
        }

        public string sBusctar
        {
            set { ViewState["VSsBusctar"] = value; }
            get { return (string)ViewState["VSsBusctar"]; }
        }

        #endregion

        
    }
}