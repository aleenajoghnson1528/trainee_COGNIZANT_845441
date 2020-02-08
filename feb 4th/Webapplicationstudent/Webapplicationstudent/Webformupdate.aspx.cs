using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapplicationstudent
{
    public partial class Webformupdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertStudent1 ad3 = new InsertStudent1();
            int idnew1 = Convert.ToInt32(TextBox1.Text);
            DateTime newdate = Convert.ToDateTime(TextBox2.Text);
            ad3.update(idnew1,newdate);
           
        }
    }
}