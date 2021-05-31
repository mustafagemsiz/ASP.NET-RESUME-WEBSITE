using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CvProject
{
    public partial class Sifre : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUSTAFA;Initial Catalog=Db_PortfolioSite;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Giris.aspx");
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            if(TxtPassword.Text!="" && TxtPassword.Text!=" ")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE TBLADMIN SET SIFRE=@p2 WHERE ID=1", baglanti);
                komut.Parameters.AddWithValue("@p2", TxtPassword.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Response.Write("<script>alert('Güncelleme işlemi başarılı.')</script>");

            }
            else
            {
                Response.Write("<script>alert('Boş alan bırakmayınız!')</script>");
            }




        }

        protected void BtnUsername_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text != "" && TxtUsername.Text != " ")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE TBLADMIN SET KULLANICI=@p2 WHERE ID=1", baglanti);
                komut.Parameters.AddWithValue("@p2", TxtUsername.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Response.Write("<script>alert('Güncelleme işlemi başarılı.')</script>");

            }
            else
            {
                Response.Write("<script>alert('Boş alan bırakmayınız!')</script>");
            }
        }
    }
}