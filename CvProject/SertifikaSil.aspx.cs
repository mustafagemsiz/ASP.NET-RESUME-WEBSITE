using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class SertifikaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }
            byte id = Convert.ToByte(Request.QueryString["ID"]);
            if (id != 0 && id<=254)
            {
                DataSet1TableAdapters.TBLSERTIFIKATableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKATableAdapter();
                dt.DeleteCertificate(Convert.ToByte(id));
                Response.Redirect("Sertifika.aspx");
            }
            else
            {
                Response.Redirect("Sertifika.aspx");

            }
        }
    }
}