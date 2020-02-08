using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace task_employee_6th
{
    public partial class selectwebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_click1(object sender, EventArgs e)
        {

            /* TraineeDataLayer ad2 = new TraineeDataLayer();
             int idnew = Convert.ToInt32(TextBox1.Text);   // idnew is any variable
             var singlestudent = ad2.Datashow(idnew);
             GridView1.DataSource = singlestudent;
             GridView1.DataBind();  */


             TraineeDataLayer ad2 = new TraineeDataLayer();
            ad2.Tid = Convert.ToInt32(TextBox1.Text);  //Tid is propery name in class
            DataSet singlestudent = ad2.Datashow();
            if(singlestudent.Tables[0].Rows.Count==0)
                {
                Label2.Text = "not valid";
               }
            else
            {
                Label2.Text = " ";
            }
            GridView1.DataSource = singlestudent;
            GridView1.DataBind();  
        }
    }
}