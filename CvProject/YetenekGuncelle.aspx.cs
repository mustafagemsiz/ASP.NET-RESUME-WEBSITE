using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class YetenekGuncelle : System.Web.UI.Page
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
                    DataSet1TableAdapters.TBLYETENEKTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
                    TxtId.Text = dt.List_Skill(Convert.ToByte(id))[0].ID.ToString();
                    TxtSkill.Text = dt.List_Skill(Convert.ToByte(id))[0].YETENEK.ToString();
                }
            }
            else
            {
                Response.Write("<script>alert('Hatalı İşlem! Yeniden Deneyiniz.')</script>");
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            dt.UpdateSkill(TxtSkill.Text, Convert.ToByte(TxtId.Text));
            Response.Redirect("Yetenek.aspx");
        }
    }
}