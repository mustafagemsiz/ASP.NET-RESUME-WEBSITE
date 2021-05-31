using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
                TxtName.Text = dt.ListAbout()[0].AD;
                TxtSurname.Text = dt.ListAbout()[0].SOYAD;
                TxtAddress.Text = dt.ListAbout()[0].ADRES;
                TxtMail.Text = dt.ListAbout()[0].MAIL;
                TxtPhone.Text = dt.ListAbout()[0].TELEFON;
                TxtDescription.Text = dt.ListAbout()[0].KISANOT;
                TxtPhoto.Text = dt.ListAbout()[0].FOTOGRAF;
            }


        }

        protected void Update_Click(object sender, EventArgs e)
        {
            if(TxtName.Text!=""&& TxtSurname.Text!=""&& TxtAddress.Text != "" && TxtMail.Text != "" && TxtPhoto.Text != "" && TxtPhoto.Text != ""&& TxtDescription.Text!="")
            {
                DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
                dt.UpdateAbout(TxtName.Text,TxtSurname.Text,TxtMail.Text,TxtAddress.Text,TxtPhone.Text,TxtDescription.Text,TxtPhoto.Text);
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("<script>alert('İşlem başarısız. Boş alan bırakmayınız!')</script>");
            }

        }
    }
}