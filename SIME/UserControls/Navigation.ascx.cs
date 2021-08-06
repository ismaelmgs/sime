using System;
using System.Linq;
using SIME.Clases;
using SIME.DomainModel;
using System.Data;
using NucleoBase.Core;
using DevExpress.Web.Bootstrap;
using System.Web;
using System.Web.UI.WebControls;

namespace SIME {
    public partial class Navigation : System.Web.UI.UserControl
    {
        public void LoadMenu(DataTable dt)
        {
            CargaMenu(dt);
        }

        private void CargaMenu(DataTable dt)
        {
            DataRow[] rows = dt.Select("ID_ItemPadre = 0");
            if (rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    int iIdPadre = rows[i]["ID_Item"].S().I();

                    BootstrapTreeViewNode oNodo = new BootstrapTreeViewNode();
                    oNodo.Text = rows[i]["Des_Item"].S();

                    DataRow[] rowshijos = dt.Select("ID_ItemPadre = " + iIdPadre.S());
                    if (rowshijos.Length > 0)
                    {
                        for (int j = 0; j < rowshijos.Length; j++)
                        {
                            BootstrapTreeViewNode oNodoHijo = new BootstrapTreeViewNode();
                            oNodoHijo.Text = rowshijos[j]["Des_Item"].S();
                            oNodoHijo.NavigateUrl = rowshijos[j]["Des_URL"].S();

                            oNodo.Nodes.Add(oNodoHijo);
                        }
                    }
                    else
                    {
                        oNodo.NavigateUrl = rows[i]["Des_URL"].S();
                    }

                    tvMenu.Nodes.Add(oNodo);
                }
            }
        }


        //private void CargaMenu(DataTable dt)
        //{
        //    DataRow[] rows = dt.Select("ID_ItemPadre = 0");
        //    if (rows.Length > 0)
        //    {
        //        for (int i = 0; i < rows.Length; i++)
        //        {
        //            int iIdPadre = rows[i]["ID_Item"].S().I();

        //            BootstrapMenuItem oNodo = new BootstrapMenuItem();
        //            oNodo.Text = rows[i]["Des_Item"].S();
        //            oNodo.IconCssClass = "fa fa-home";

        //            DataRow[] rowshijos = dt.Select("ID_ItemPadre = " + iIdPadre.S());
        //            if (rowshijos.Length > 0)
        //            {
        //                for (int j = 0; j < rowshijos.Length; j++)
        //                {
        //                    BootstrapMenuItem oNodoHijo = new BootstrapMenuItem();
        //                    oNodoHijo.Text = rowshijos[j]["Des_Item"].S();
        //                    oNodoHijo.NavigateUrl = rowshijos[j]["Des_URL"].S();

        //                    oNodo.Items.Add(oNodoHijo);
        //                }
        //            }
        //            else
        //            {
        //                oNodo.NavigateUrl = rows[i]["Des_URL"].S();
        //            }

        //            tvMenu.Items.Add(oNodo);
        //        }
        //    }
        //}
    }
}