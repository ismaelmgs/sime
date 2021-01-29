using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIME.ControlesUsuario
{
    public partial class ucMensaje : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnOK.OnClientClick = String.Format("fnClickOK('{0}','{1}')", btnOK.UniqueID, "");
        }
        
        public void ShowMessage(string Message, string Caption)
        {
            lblMessage.Text = Message;
            lblCaption.Text = Caption;
            ppMensaje.HeaderText = Caption;
            ppMensaje.ShowOnPageLoad = true;
        }

        public void Hide()
        {
            lblMessage.Text = "";
            lblCaption.Text = "";
            ppMensaje.ShowOnPageLoad = false;
        }

        public void btnOk_Click(object sender, EventArgs e)
        {
            OnOkButtonPressed(e);
        }

        public delegate void OkButtonPressedHandler(object sender, EventArgs args);
        public event OkButtonPressedHandler OkButtonPressed;

        protected virtual void OnOkButtonPressed(EventArgs e)
        {
            if (OkButtonPressed != null)
                OkButtonPressed(btnOK, e);
        }
    }
}