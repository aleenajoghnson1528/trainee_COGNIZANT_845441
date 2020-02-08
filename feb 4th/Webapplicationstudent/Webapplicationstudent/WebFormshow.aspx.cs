using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapplicationstudent
{
    public partial class WebFormshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_click1(object sender, EventArgs e)
        {
            InsertStudent1 ad2 = new InsertStudent1();
            int idnew= Convert.ToInt32(TextBox1.Text);
            var singlestudent = ad2.Datashow(idnew);
            GridView1.DataSource = singlestudent;
            GridView1.DataBind();

        }
    }
}