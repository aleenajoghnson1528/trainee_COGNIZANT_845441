using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_employee_6th
{
    public partial class webformupdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            TraineeDataLayer ad3 = new TraineeDataLayer();

            int idnew1 = Convert.ToInt32(TextBox1.Text);
            string newdomain = TextBox2.Text;
            ad3.update(idnew1, newdomain);
        }
    }
}