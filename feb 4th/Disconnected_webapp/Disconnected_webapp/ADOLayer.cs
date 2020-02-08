using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Disconnected_webapp
{
    public class ADOLayer
    {
        string constr = " ";
        public ADOLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string selquery = "select * from student";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return ds;
        }   
    }
}