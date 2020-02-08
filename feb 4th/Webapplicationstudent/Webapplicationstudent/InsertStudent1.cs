using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;//dataset namespace
using System.Data.SqlClient;//namespace for configuration manager
using System.Configuration;


namespace Webapplicationstudent
{ 
    public class InsertStudent1
    {
        DataSet ds = new DataSet();
        string constring = "";
        public InsertStudent1()
        {
            constring = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;

        }


        public void update(int id,DateTime dt)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.Parameters.AddWithValue("@StartDate",dt);
                    cmd.CommandText = "updatedata";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }




        public DataSet Datashow(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection (constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.CommandText = "selectonerecord";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return (ds);
        }


        public void insert(int sid, string sname, string course, DateTime startdate)
        {

            try
            {

                using (SqlConnection con = new SqlConnection(constring))
                {

                    con.Open();
                    SqlCommand cm = new SqlCommand();
                    cm.Parameters.AddWithValue("@SId", sid);
                    cm.Parameters.AddWithValue("@Sname", sname);
                    cm.Parameters.AddWithValue("@Course", course);
                    cm.Parameters.AddWithValue("@StartDate", startdate);
                    cm.CommandText = "InsertRecordnew";
                    cm.Connection = con;
                    cm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cm);
                    sd.Fill(ds);
                    sd.Update(ds);
                }

            }
            catch (Exception e)
            {

            }
        }
        public void selectrow(int SId)
        {

            try
            {

                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand();
                   
                    cm.CommandText = "selectonerecord";
                    cm.Connection = con;
                    cm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cm);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch (Exception e)
            {

            }
        
        }
        
    }
}
