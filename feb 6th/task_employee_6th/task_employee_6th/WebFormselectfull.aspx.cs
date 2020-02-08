using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_employee_6th
{
    public partial class WebFormselectfull : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                TraineeDataLayer ad2 = new TraineeDataLayer();
                var singlestudent = ad2.selectfull();
                GridView1.DataSource = singlestudent;
                GridView1.DataBind();
            }
        }

      
    }
    
}