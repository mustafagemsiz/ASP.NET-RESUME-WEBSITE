using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class DeneyimEkle : System.Web.UI.Page
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


            if (TxtTitle.Text != "" && TxtSubtitle.Text != "" && TxtDescription.Text != "" && TxtDate.Text != "")
            {
                DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                dt.InsertExperience(TxtTitle.Text, TxtSubtitle.Text, TxtDescription.Text, TxtDate.Text);
                Response.Redirect("Deneyim.aspx");
            }
            else
            {
                Response.Write("<script>alert('İşlem başarısız. Boş alan bırakmayınız!')</script>");
            }

        }
    }
}