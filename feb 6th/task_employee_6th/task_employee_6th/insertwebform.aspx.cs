using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_employee_6th
{
    public partial class insertwebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                TraineeDataLayer ad1 = new TraineeDataLayer();
               ad1.Tid = Convert.ToInt32(TextBox1.Text);
                ad1.Tname = TextBox2.Text;
                ad1.Location = TextBox3.Text;
                ad1.Techdomain = TextBox4.Text;
                ad1.Startdate = Convert.ToDateTime(TextBox5.Text);
                ad1.insert();
                //var singlestudent = ad1.getdata(idno);
                //GridView1.DataSource=singlestudent;
            }
            else
            {
                newlabel.Text = "enter all fields";
            }
        }

       
    }
}