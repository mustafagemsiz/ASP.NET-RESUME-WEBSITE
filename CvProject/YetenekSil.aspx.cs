using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class YetenekSil : System.Web.UI.Page
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

                DataSet1TableAdapters.TBLYETENEKTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
                dt.DeleteSkill(Convert.ToByte(id));
                Response.Redirect("Yetenek.aspx");

            }
            else
            {
                Response.Redirect("Yetenek.aspx");
            }
        }
    }
}