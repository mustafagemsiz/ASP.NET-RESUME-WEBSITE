using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class Yetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }
            DataSet1TableAdapters.TBLYETENEKTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            Repeater1.DataSource = dt.ListSkill();
            Repeater1.DataBind();
        }
    }
}