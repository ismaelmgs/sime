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

namespace SIME.Views
{
    public partial class frmRegistoClientes : System.Web.UI.Page, IRegistoClientesView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new RegistoClientesPresenter(this, new DBRegistoClientes());

            if (!IsPostBack)
            {
                rdnFisica.Checked = true;
                rdnMoral.Checked = false;
                IdTipoPersona = 1;
                divMoral.Visible = false;
                divFisica.Visible = true;
            }
        }

        protected void chkFisica_CheckedChanged(object sender, EventArgs e)
        {
            rdnFisica.Checked = true;
            rdnMoral.Checked = false;
            IdTipoPersona = 1;
            divMoral.Visible = false;
            divFisica.Visible = true;
        }

        protected void chkMoral_CheckedChanged(object sender, EventArgs e)
        {
            rdnFisica.Checked = false;
            rdnMoral.Checked = true;
            IdTipoPersona = 2;
            divMoral.Visible = true;
            divFisica.Visible = false;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (eInsertaClientes != null)
                eInsertaClientes(sender, e);
        }

        #region MÉTODOS

        public void MostrarMensaje(DataTable dt)
        {
            try
            {
                ucMensaje.ShowMessage(dt.Rows[0][1].ToString(), "¡Informacion!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region VARIABLES Y PROPIEDADES

        RegistoClientesPresenter oPresenter;

        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;

        public event EventHandler eInsertaClientes;

        public int IdTipoPersona
        {
            set { ViewState["VSResponsable"] = value; }
            get { return (int)ViewState["VSResponsable"]; }
        }

        public Registro oRegistro
        {
            get
            {
                return new Registro
                {
                    Id_Tipo_Persona = IdTipoPersona, 
                    Razon_Social = txtRazon_Social.Text, 
                    Sector = txtSector.Text, 
                    Primer_Nombre = txtPrimer_Nombre.Text, 
                    Segundo_Nombre = txtSegundo_Nombre.Text, 
                    App_Pat = txtApp_Pa.Text, 
                    App_Mat = txtApp_Mat.Text, 
                    RFC = txtRFC.Text, 
                    Calle = txtCalle.Text, 
                    Num_Ext = txtNum_Ext.Text, 
                    Num_Int = txtNum_Int.Text, 
                    CP = txtCP.Text, 
                    Colonia = txtColonia.Text, 
                    Mpio_Del = txtMpio_Del.Text, 
                    Ciudad = txtCiudad.Text, 
                    Pais = txtPais.Text, 
                    Fec_Nac = txtFec_Nac.Text, 
                    Identificacion = txtIdentificacion.Text, 
                    Id_Status = 1, 
                    Usuario_Registro = "System", 
                    Fecha_Registro = DateTime.Now, 
                    Contacto_Servicios = txtContacto_Servicios.Text, 
                    Tel_Cont_serv = txtTel_Cont_serv.Text, 
                    Mail_Cont_serv = txtMail_Cont_serv.Text, 
                    Contacto_Administrativo = txtContacto_Administrativo.Text, 
                    Tel_Cont_adm = txtTel_Cont_adm.Text, 
                    Mail_Cont_adm = txtMail_Cont_adm.Text, 
                };
            }
            set
            { }
        }

		#endregion

		protected void rdnFisica_CheckedChanged(object sender, EventArgs e)
		{
            rdnFisica.Checked = true;
            rdnMoral.Checked = false;
            IdTipoPersona = 1;
            divMoral.Visible = false;
            divFisica.Visible = true;
        }

		protected void rdnMoral_CheckedChanged(object sender, EventArgs e)
		{
            rdnFisica.Checked = false;
            rdnMoral.Checked = true;
            IdTipoPersona = 2;
            divMoral.Visible = true;
            divFisica.Visible = false;
        }
	}
}