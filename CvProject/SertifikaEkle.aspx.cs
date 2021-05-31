using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class SertifikaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            if (TxtCertificate.Text != "" && TxtCertificate.Text != " ")
            {
                DataSet1TableAdapters.TBLSERTIFIKATableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKATableAdapter();
                dt.InsertCertificate(TxtCertificate.Text);
                Response.Redirect("Sertifika.aspx");
            }
            else
            {
                Response.Write("<script>alert('İşlem başarısız. Boş alan bırakmayınız!')</script>");
            }
        }
    }
}