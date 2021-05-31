using System;

namespace CvProject
{
    public partial class EğitimEkle : System.Web.UI.Page
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
            if (TxtTitle.Text != "" && TxtSubtitle.Text != "" && TxtDescription.Text != "" && TxtDate.Text != "" &&TxtGnot.Text!="")
            {
                DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                dt.InsertEducation(TxtTitle.Text, TxtSubtitle.Text, TxtDescription.Text, TxtGnot.Text, TxtDate.Text);
                Response.Redirect("Egitim.aspx");
            }
            else
            {
                Response.Write("<script>alert('İşlem başarısız. Boş alan bırakmayınız!')</script>");
            }
        }
    }
}