using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
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
                if (Page.IsPostBack == false)
                {
                    DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                    TxtTitle.Text = dt.List_Experience(Convert.ToByte(id))[0].BASLIK;
                    TxtSubtitle.Text = dt.List_Experience(Convert.ToByte(id))[0].ALTBASLIK;
                    TxtDescription.Text = dt.List_Experience(Convert.ToByte(id))[0].ACIKLAMA;
                    TxtDate.Text = dt.List_Experience(Convert.ToByte(id))[0].TARIH;
                    TxtId.Text = dt.List_Experience(Convert.ToByte(id))[0].ID.ToString();
                }
            }
            else
            {
                Response.Write("<script>alert('Hatalı İşlem! Yeniden Deneyiniz.')</script>");
            }

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            dt.UpdateExperience(TxtTitle.Text, TxtSubtitle.Text, TxtDescription.Text, TxtDate.Text,Convert.ToByte(TxtId.Text));
            Response.Redirect("Deneyim.aspx");

        }
    }
}