using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class EgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            byte id = Convert.ToByte(Request.QueryString["ID"]);
            if (id != 0)
            {
                
                DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                dt.DeleteEducation(Convert.ToByte(id));
                Response.Redirect("Egitim.aspx");

            }
            else
            {
                Response.Redirect("Egitim.aspx");
            }
        }
    }
}