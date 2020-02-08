using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disconnected_webapp
{
    public partial class Webformdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ADOLayer al = new ADOLayer();
                var stlist = al.Getallrecords();
                GridView1.DataSource = stlist;
                GridView1.DataBind();   

                
            }
        }
        
    }
}