using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Webapplicationstudent
{
    public partial class webformdata : System.Web.UI.Page
    {
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertStudent1 ad1 = new InsertStudent1();
            int idno = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            string course = TextBox3.Text;
            DateTime date = Convert.ToDateTime(TextBox4.Text);
            ad1.insert(idno, name, course, date);
            //var singlestudent = ad1.getdata(idno);
            //GridView1.DataSource=singlestudent;
           


        }
    }
}