using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class HobiSil : System.Web.UI.Page
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
                DataSet1TableAdapters.TBLHOBITableAdapter dt = new DataSet1TableAdapters.TBLHOBITableAdapter();
                dt.DeleteHobby(Convert.ToByte(id));
                Response.Redirect("Hobi.aspx");
            }
            else
            {
                Response.Redirect("Hobi.aspx");
            }
        }
    }
}