using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CvProject
{
    public partial class Giris : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUSTAFA;Initial Catalog=Db_PortfolioSite;Integrated Security=True");
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT*FROM TBLADMIN WHERE KULLANICI=@p1 AND SIFRE=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", username.Text);
            komut.Parameters.AddWithValue("@p2", password.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("KULLANICI", username.Text);
                Response.Redirect("Deneyim.aspx");
                
            }
            else
            {
            Response.Write("<script>alert('İşlem başarısız. Hatalı Kullanıcı Adı veya Şifre!')</script>");
            }
        }
    }
}