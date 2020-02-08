using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;//dataset namespace
using System.Data.SqlClient;//namespace for configuration manager
using System.Configuration;


namespace task_employee_6th
{
    public class TraineeDataLayer :Trainee
    {
        DataSet ds = new DataSet();
        string constring = "";
        public TraineeDataLayer()
        {
            constring = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;

        }


        public void insert()
        {

            try
            {

                using (SqlConnection con = new SqlConnection(constring))
                {

                    con.Open();
                    SqlCommand cm = new SqlCommand();
                    cm.Parameters.AddWithValue("@Tid", Tid);
                    cm.Parameters.AddWithValue("@Tname", Tname);
                    cm.Parameters.AddWithValue("@Location", Location);
                    cm.Parameters.AddWithValue("@StartDate", Startdate);
                    cm.Parameters.AddWithValue("@Techdomain", Techdomain);
                    cm.CommandText = "Inserttotable";
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


        public void update(int id, string dt)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.AddWithValue("@Tid", id);
                 
                    cmd.Parameters.AddWithValue("@Techdomain", dt);
                   
                    cmd.CommandText = "updatetable";
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


        public DataSet selectfull()
        {
            DataSet ds = new DataSet();

            try
            {

                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand();
                    
                    cm.CommandText = "selectfulldata";
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
            return ds;

        }



        /*  public DataSet Datashow(int id)
          {
              DataSet ds = new DataSet();
              try
              {
                  using (SqlConnection con = new SqlConnection(constring))
                  {
                      con.Open();
                      SqlCommand cmd = new SqlCommand();
                      cmd.Parameters.AddWithValue("@TId", id);
                      cmd.CommandText = "selectone";
                      cmd.Connection = con;
                      cmd.CommandType = CommandType.StoredProcedure;
                      SqlDataAdapter ada = new SqlDataAdapter(cmd);
                      ada.Fill(ds);
                  }
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.Message);
              }
              return (ds);
          }
          */
          public DataSet Datashow()
       {
           //DataSet ds = new DataSet();
           try
           {
               using (SqlConnection con = new SqlConnection(constring))
               {
                   con.Open();
                   SqlCommand cmd = new SqlCommand();
                   cmd.Parameters.AddWithValue("@TId", Tid);
                   cmd.CommandText = "selectone";
                   cmd.Connection = con;
                   cmd.CommandType = CommandType.StoredProcedure;
                   SqlDataAdapter ada = new SqlDataAdapter(cmd);
                   ada.Fill(ds);
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
           return (ds);
       }
       

    }
}