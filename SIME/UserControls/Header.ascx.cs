using System;
using System.Linq;
using DevExpress.Web.Bootstrap;
using SIME.Clases;

namespace SIME
{
    public partial class Header : System.Web.UI.UserControl
    {
        public void LoadUserDates()
        {
            //lblNombre.Text = Utils.GetNombreUsuario;
            //lblPerfil.Text = Utils.GetDescPerfilUsuario;

            BootstrapToolbarItem oItem = new BootstrapToolbarItem();
            oItem.CssClass = "no-icon demo-header-user-info align-items-center border-0 bg-light text-dark";
            oItem.Text = "  " + Utils.GetNombreUsuario;

            BootstrapToolbarMenuItem oPerfil = new BootstrapToolbarMenuItem();
            oPerfil.Text = "Perfil";
            oPerfil.Name = "Perfil";
            oPerfil.IconCssClass = "demo-icon demo-icon-user";

            BootstrapToolbarMenuItem oSalir = new BootstrapToolbarMenuItem();
            oSalir.Text = "Salir";
            oSalir.Name = "Salir";
            oSalir.IconCssClass = "demo-icon demo-icon-logout";


            oItem.Items.Add(oPerfil);
            oItem.Items.Add(oSalir);

            btbUsuario.Items.Add(oItem);
        }

        protected void BootstrapToolbar1_ItemClick(object source, DevExpress.Web.Bootstrap.BootstrapToolbarItemEventArgs e)
        {
            if (e.Item.Name == "Salir")
            {
                Session["UserIdentity"] = null;
                Response.Redirect("~/Views/frmLogin.aspx");
            }

            if (e.Item.Name == "Perfil" && Utils.GetPerfilUsuario == 4)
            {
                string sIdProv = Utils.EncodeStrToBase64(Utils.GetIdProveedor.ToString());
                Response.Redirect("frmRegistroProveedor.aspx?IdPro=" + sIdProv);
            }
        }

    }
}