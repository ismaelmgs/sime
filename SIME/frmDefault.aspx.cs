using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIME
{
    public partial class frmDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenaGridView();
        }

        private void LlenaGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                CreaEstructuraTabla(dt);

                for (int i = 0; i < 10; i++)
                {
                    DataRow row = dt.NewRow();
                    row["Columna1"] = i + 1;
                    row["Columna2"] = "Columna2" + (i + 1).ToString();
                    row["Columna3"] = "Columna3" + (i + 1).ToString();
                    row["Columna4"] = "Columna4" + (i + 1).ToString();


                    dt.Rows.Add(row);
                }

                gvPrueba.DataSource = dt;
                gvPrueba.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreaEstructuraTabla(DataTable dt)
        {
            dt.Columns.Add("Columna1", typeof(int));
            dt.Columns.Add("Columna2");
            dt.Columns.Add("Columna3");
            dt.Columns.Add("Columna4");
        }

    }
}