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
using SIME.Clases;

namespace SIME.Views
{
    public partial class frmRegistoClientes : System.Web.UI.Page, IRegistoClientesView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new RegistoClientesPresenter(this, new DBRegistoClientes());

            if (!IsPostBack)
            {
                chkFisica.Checked = true;
                chkMoral.Checked = false;
                IdTipoPersona = 1;
                divMoral.Visible = false;
                divFisica.Visible = true;

                iIdCliente = 0;
                if (Request.QueryString["IdCli"] != null)
                {
                    string sIdCliente = Request.QueryString["IdCli"].S();
                    iIdCliente = Utils.DecodeBase64ToString(sIdCliente).S().I();

                    if (eObjSelected != null)
                        eObjSelected(sender, e);
                }
            }
        }

        protected void chkFisica_CheckedChanged(object sender, EventArgs e)
        {
            chkFisica.Checked = true;
            chkMoral.Checked = false;
            IdTipoPersona = 1;
            divMoral.Visible = false;
            divFisica.Visible = true;
        }

        protected void chkMoral_CheckedChanged(object sender, EventArgs e)
        {
            chkFisica.Checked = false;
            chkMoral.Checked = true;
            IdTipoPersona = 2;
            divMoral.Visible = true;
            divFisica.Visible = false;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (iIdCliente == 0)
            {
                if (eInsertaClientes != null)
                    eInsertaClientes(sender, e);
            }
            else
            {
                if (eSaveObj != null)
                    eSaveObj(sender, e);
            }
        }

        #region MÉTODOS

        public void MostrarMensaje(string sMensaje, string sTitulo)
        {
            try
            {
                ucMensaje.ShowMessage(sMensaje, sTitulo);
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

        public int iIdCliente
        {
            set { ViewState["VSiIdCliente"] = value; }
            get { return (int)ViewState["VSiIdCliente"]; }
        }

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
                    iIdCliente = iIdCliente,
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
                    Fec_Nac = txtFec_Nac.Value.S().Dt(), 
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
            {
                Registro oReg = value;
                if (oReg.Id_Tipo_Persona == 1)
                {
                    chkFisica.Checked = true;
                    chkMoral.Checked = false;

                    chkFisica_CheckedChanged(null, EventArgs.Empty);
                }
                else
                {
                    chkFisica.Checked = false;
                    chkMoral.Checked = true;
                    chkMoral_CheckedChanged(null, EventArgs.Empty);
                }
                
                
                txtRazon_Social.Text = oReg.Razon_Social;
                txtSector.Text = oReg.Sector;
                txtPrimer_Nombre.Text = oReg.Primer_Nombre;
                txtSegundo_Nombre.Text = oReg.Segundo_Nombre;
                txtApp_Pa.Text = oReg.App_Pat;
                txtApp_Mat.Text = oReg.App_Mat;
                txtRFC.Text = oReg.RFC;
                txtCalle.Text = oReg.Calle;
                txtNum_Ext.Text = oReg.Num_Ext;
                txtNum_Int.Text = oReg.Num_Int;
                txtCP.Text = oReg.CP;
                txtColonia.Text = oReg.Colonia;
                txtMpio_Del.Text = oReg.Mpio_Del;
                txtCiudad.Text = oReg.Ciudad;
                txtPais.Text = oReg.Pais;
                txtFec_Nac.Value = oReg.Fec_Nac.S();
                txtIdentificacion.Text = oReg.Identificacion;
                txtContacto_Servicios.Text = oReg.Contacto_Servicios;
                txtTel_Cont_serv.Text = oReg.Tel_Cont_serv;
                txtMail_Cont_serv.Text = oReg.Mail_Cont_serv;
                txtContacto_Administrativo.Text = oReg.Contacto_Administrativo;
                txtTel_Cont_adm.Text = oReg.Tel_Cont_adm;
                txtMail_Cont_adm.Text = oReg.Mail_Cont_adm;     
            }
        }

		#endregion

		protected void rdnFisica_CheckedChanged(object sender, EventArgs e)
		{
            chkFisica.Checked = true;
            chkMoral.Checked = false;
            IdTipoPersona = 1;
            divMoral.Visible = false;
            divFisica.Visible = true;
        }

		protected void rdnMoral_CheckedChanged(object sender, EventArgs e)
		{
            chkFisica.Checked = false;
            chkMoral.Checked = true;
            IdTipoPersona = 2;
            divMoral.Visible = true;
            divFisica.Visible = false;
        }
	}
}