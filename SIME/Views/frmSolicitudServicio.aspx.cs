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
using DevExpress.Web;
using System.IO;
using DevExpress.Web.Internal;
using System.Drawing;
using SIME.Objetos;

namespace SIME.Views
{
    public partial class frmSolicitudServicio : System.Web.UI.Page, ISolicitudServicio
    {
        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            ucMensaje.OkButtonPressed += ucMensaje_OkButtonPressed;
            oPresenter = new SolicitudServicio_Presenter(this, new DBSolicitudServicio());

            if (!IsPostBack)
            {
                if (eObjSelected != null)
                    eObjSelected(sender, e);
            }
        }

        private void ucMensaje_OkButtonPressed(object sender, EventArgs args)
        {
            ucMensaje.Hide();
        }

        protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (eGetSubCategorias != null)
                    eGetSubCategorias(sender, e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (dtServicios == null)
                dtServicios = CreaEstructuraTabla();

            DataRow dr = dtServicios.NewRow();
            dr["Index"] = dtServicios.Rows.Count;
            dr["Categoria"] = ddlCategorias.Text.S();
            dr["IdCategoria"] = ddlCategorias.Value.S();
            dr["Subcategoria"] = ddlSubcategoria.Text.S();
            dr["IdSubcategoria"] = ddlSubcategoria.Value.S();

            dtServicios.Rows.Add(dr);

            gvServicios.DataSource = dtServicios;
            gvServicios.DataBind();
        }

        protected void gvServicios_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            string sOpcion = ((DevExpress.Web.ASPxButton)e.CommandSource).CommandName.S();
            int iIndex = e.CommandArgs.CommandArgument.S().I();
            iIndex = e.VisibleIndex;

            if (sOpcion == "Eliminar")
            {
                dtServicios.Rows.RemoveAt(iIndex);

                gvServicios.DataSource = dtServicios;
                gvServicios.DataBind();
            }
        }

        protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            oFoto1 = new Fotografia();
            string file = string.Empty;
            oFoto1.sFoto = SavePostedFile(e.UploadedFile, out file);
            oFoto1.sNombre = file;
            oFoto1.sExtension = Path.GetExtension(e.UploadedFile.FileName);
        }

        protected void UploadControl2_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            oFoto2 = new Fotografia();
            string file = string.Empty;
            oFoto2.sFoto = SavePostedFile(e.UploadedFile, out file);
            oFoto2.sNombre = file;
            oFoto2.sExtension = Path.GetExtension(e.UploadedFile.FileName);
        }

        protected void UploadControl3_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            oFoto3 = new Fotografia();
            string file = string.Empty;
            oFoto3.sFoto = SavePostedFile(e.UploadedFile, out file);
            oFoto3.sNombre = file;
            oFoto3.sExtension = Path.GetExtension(e.UploadedFile.FileName);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (eNewObj != null)
                    eNewObj(sender, e);

                LimpiaControles();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region METODOS
        public void MostrarMensaje(string sMensaje, string sTitulo)
        {
            ucMensaje.ShowMessage(sMensaje, sTitulo);
        }

        public void LoadCatalogos(DataTable dt)
        {
            ddlCategorias.DataSource = dt;
            ddlCategorias.TextField = "Descripcion";
            ddlCategorias.ValueField = "IdCategoria";
            ddlCategorias.DataBind();

            if (eGetSubCategorias != null)
                eGetSubCategorias(null, EventArgs.Empty);
        }

        public void LoadSubCategoria(DataTable dt)
        {
            ddlSubcategoria.DataSource = dt;
            ddlSubcategoria.TextField = "Descripcion";
            ddlSubcategoria.ValueField = "IdSubcategoria";
            ddlSubcategoria.DataBind();
        }

        private DataTable CreaEstructuraTabla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Index");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("IdCategoria");
            dt.Columns.Add("Subcategoria");
            dt.Columns.Add("IdSubcategoria");

            return dt;
        }

        private void LimpiaControles()
        {
            ddlCategorias.SelectedIndex = -1;
            ddlSubcategoria.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;

            dtServicios = null;
            gvServicios.DataSource = null;
            gvServicios.DataBind();

            oFoto1 = null;
            oFoto2 = null;
            oFoto3 = null;
        }

        protected string SavePostedFile(UploadedFile uploadedFile, out string filename)
        {
            if (!uploadedFile.IsValid)
            {
                filename = "";
                return string.Empty;
            }

            string sMes = DateTime.Now.Month.S().PadLeft(2, '0');
            string sAnio = DateTime.Now.Year.S();

            string file = Path.ChangeExtension(Path.GetRandomFileName(), ".jpg");
            filename = sAnio + sMes + "_" + file;

            string fullFileName = CombinePath(filename);
            using (System.Drawing.Image original = System.Drawing.Image.FromStream(uploadedFile.FileContent))
            using (System.Drawing.Image thumbnail = new ImageThumbnailCreator(original).CreateImageThumbnail(new Size(850, 850)))
                ImageUtils.SaveToJpeg((Bitmap)thumbnail, fullFileName);
            
            return fullFileName;
        }

        protected string CombinePath(string fileName)
        {
            return Path.Combine(Server.MapPath(UploadDirectory), fileName);
        }

        const string UploadDirectory = "~/ImagenesSolicitud/";

        #endregion


        #region VARIABLES Y PROPIEDADES
        SolicitudServicio_Presenter oPresenter;
        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;
        public event EventHandler eGetSubCategorias;
        
        public int iIdCategoria
        {
            get {
                return ddlCategorias.Value.S().I();
            }
        }
        
        public DataTable dtServicios
        {
            set { ViewState["VSServicios"] = value; }
            get { return (DataTable)ViewState["VSServicios"]; }
        }

        public Fotografia oFoto1
        {
            set { Session["VSFoto1"] = value; }
            get { return (Fotografia)Session["VSFoto1"]; }
        }

        public Fotografia oFoto2
        {
            set { Session["VSFoto2"] = value; }
            get { return (Fotografia)Session["VSFoto2"]; }
        }

        public Fotografia oFoto3
        {
            set { Session["VSFoto3"] = value; }
            get { return (Fotografia)Session["VSFoto3"]; }
        }

        public SolicitudServicio oServ
        {
            get
            {
                SolicitudServicio oSer = new SolicitudServicio();
                oSer.sDescripcion = txtDescripcion.Text.S();

                if (oSer.oLstFotos == null)
                    oSer.oLstFotos = new List<Fotografia>();

                foreach (DataRow row in dtServicios.Rows)
                {
                    CategoriaServ oCat = new CategoriaServ();
                    oCat.iIdCategoria = row["IdCategoria"].S().I();
                    oCat.iIdSubcategoria = row["IdSubcategoria"].S().I();

                    oSer.oLstCat.Add(oCat);
                }

                if (oFoto1 != null)
                    oSer.oLstFotos.Add(oFoto1);

                if (oFoto2 != null)
                    oSer.oLstFotos.Add(oFoto2);

                if (oFoto3 != null)
                    oSer.oLstFotos.Add(oFoto3);

                return oSer;
            }
            set
            {

            }
        }

        #endregion
    }
}