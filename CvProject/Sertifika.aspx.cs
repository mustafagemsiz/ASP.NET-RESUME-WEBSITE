using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class Sertifika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }
            DataSet1TableAdapters.TBLSERTIFIKATableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKATableAdapter();
            Repeater1.DataSource = dt.ListCertificate();
            Repeater1.DataBind();
        }
    }
}