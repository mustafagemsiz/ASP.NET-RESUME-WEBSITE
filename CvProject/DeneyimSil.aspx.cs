using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class DeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }

            byte id = Convert.ToByte(Request.QueryString["ID"]);
            if (id != 0)
            {
                DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                dt.DeleteExperience(Convert.ToByte(id));
                Response.Redirect("Deneyim.aspx");
            }
            else
            {
                Response.Redirect("Deneyim.aspx");
            }
        }
    }
}