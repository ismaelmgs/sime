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
using DevExpress.Web;
using System.IO;

namespace SIME.Views
{
    public partial class frmMisSolicitudes : System.Web.UI.Page, IMisSolicitudes
    {
        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new MisSolicitudes_Presenter(this, new DBMisSolicitudes());

            if (!IsPostBack)
            {
                if (eSearchObj != null)
                    eSearchObj(sender, e);

                ImageSlider.SettingsSlideShow.Interval = 5000;
                ImageSlider.SettingsSlideShow.AutoPlay = false;
                ImageSlider.SettingsSlideShow.PausePlayingWhenMouseOver = false;
                ImageSlider.SettingsSlideShow.PlayPauseButtonVisibility = DevExpress.Web.ElementVisibilityMode.Faded;
                ImageSlider.SettingsSlideShow.StopPlayingWhenPaging = false;
            }


            //DemoHelper.Instance.ControlAreaMaxWidth = Unit.Pixel(850);
            //DemoHelper.Instance.PrepareControlOptions(OptionsFormLayout, new ControlOptionsSettings
            //{
            //    ColumnMinWidth = 380,
            //    RightBlockWidth = 400,
            //    ColumnCountMode = RecalculateColumnCountMode.ChildGroups
            //});
            //if (IsPostBack)
            //{
                
            //}

        }

        protected void gvSolicitudes_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            try
            {
                string sOpcion = ((DevExpress.Web.ASPxButton)e.CommandSource).CommandName.S();
                iIdSolicitud = e.CommandArgs.CommandArgument.S().I();

                object cellValues = gvSolicitudes.GetRowValuesByKeyValue(iIdSolicitud, "NombreCliente" //0
                                                                                    , "Descripcion" //1
                                                                                    , "ProveedorAsignado" //2
                );

                if (sOpcion == "Imagenes")
                {
                    if (eObjSelected != null)
                        eObjSelected(sender, e);

                    ppImagenes.ShowOnPageLoad = true;
                }

                if (sOpcion == "Proveedor")
                {
                    ppProveedores.ShowOnPageLoad = true;

                    if (eGetProveedor != null)
                        eGetProveedor(sender, e);

                    gvProveedores.DataSource = dtProveedores;
                    gvProveedores.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedor = gvProveedores.GetSelectedFieldValues("Id_Prov");
                if (proveedor != null)
                {
                    iIdProveedor = proveedor[0].S().I();

                    if (eUpdProveedor != null)
                        eUpdProveedor(sender, e);

                    ppProveedores.ShowOnPageLoad = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


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

        public void CargaMisSolicitudes(DataTable dt)
        {
            gvSolicitudes.DataSource = dt;
            gvSolicitudes.DataBind();
        }

        public void CargaImagenesModal()
        {
            int iCont = 1;
            foreach (DataRow row in dsImagenes.Tables[1].Rows)
            {
                ImageSliderItem oimgs = new ImageSliderItem();
                oimgs.ImageUrl = "~/ImagenesSolicitud/" + Path.GetFileName(row["Imagen"].S());
                oimgs.NavigateUrl = iCont.S();
                ImageSlider.Items.Add(oimgs);

                iCont++;
            }
        }

        #endregion


        #region VARIABLES Y PROPIEDADES

        MisSolicitudes_Presenter oPresenter;

        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;
        public event EventHandler eGetProveedor;
        public event EventHandler eUpdProveedor;

        public int iIdSolicitud
        {
            set { ViewState["VSiIdSolicitud"] = value; }
            get { return (int)ViewState["VSiIdSolicitud"]; }
        }

        public int iIdProveedor
        {
            set { ViewState["VSiIdProveedor"] = value; }
            get { return (int)ViewState["VSiIdProveedor"]; }
        }

        public DataSet dsImagenes
        {
            set { ViewState["VSdsImagenes"] = value; }
            get { return (DataSet)ViewState["VSdsImagenes"]; }
        }

        public DataTable dtProveedores
        {
            set { ViewState["VSdtProveedores"] = value; }
            get { return (DataTable)ViewState["VSdtProveedores"]; }
        }

        #endregion

        
    }
}