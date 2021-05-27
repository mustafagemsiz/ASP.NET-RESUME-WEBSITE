using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class EgitimGuncelle : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            byte id = Convert.ToByte(Request.QueryString["ID"]);
            if (id != 0)
            {
                if (Page.IsPostBack == false)
                {
                    DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                    TxtTitle.Text = dt.List_Education(Convert.ToByte(id))[0].BASLIK;
                    TxtSubtitle.Text = dt.List_Education(Convert.ToByte(id))[0].ALTBASLIK;
                    TxtDescription.Text = dt.List_Education(Convert.ToByte(id))[0].ACIKLAMA;
                    TxtDate.Text = dt.List_Education(Convert.ToByte(id))[0].TARIH;
                    TxtGnot.Text = dt.List_Education(Convert.ToByte(id))[0].GNOT;
                    TxtId.Text = dt.List_Education(Convert.ToByte(id))[0].ID.ToString();
                }
            }
            else
            {
                Response.Write("<script>alert('Hatalı İşlem! Yeniden Deneyiniz.')</script>");
            }
          
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.UpdateEducation(TxtTitle.Text, TxtSubtitle.Text, TxtDescription.Text,TxtGnot.Text , TxtDate.Text, Convert.ToByte(TxtId.Text));
            Response.Redirect("Egitim.aspx");
        }
    }

}