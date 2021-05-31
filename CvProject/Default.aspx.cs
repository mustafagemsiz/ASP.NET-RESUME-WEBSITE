using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dtAbout = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dtAbout.ListAbout();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYIMTableAdapter dtExperience = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dtExperience.ListExperience();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGITIMTableAdapter dtEducation = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dtEducation.ListEducation();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLYETENEKTableAdapter dtSkill = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            Repeater4.DataSource = dtSkill.ListSkill();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBLHOBITableAdapter dtHobby = new DataSet1TableAdapters.TBLHOBITableAdapter();
            Repeater5.DataSource = dtHobby.ListHobby();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBLSERTIFIKATableAdapter dtCertificate = new DataSet1TableAdapters.TBLSERTIFIKATableAdapter();
            Repeater6.DataSource = dtCertificate.ListCertificate();
            Repeater6.DataBind();

            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dtImage = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater7.DataSource = dtImage.ListAbout();
            Repeater7.DataBind();


            
        }
    }
}