using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CONNETIONTODATABASE
{
    class Restaurantclass
    {
        public void insertdata()
        {
            string constr = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=restaurant;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string insertquery = "insert into Menu (Restaurant_name,item,price) values (" + " 'kerala hotel' " + " , " + " 'pineapple juice' " + " , " + " '250')";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();

            }
        }
        public void display()
        {
            string constr1 = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=restaurant;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr1))
            {
                string querystr = "select * from Menu";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader datared = cmd.ExecuteReader();
                    while (datared.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", datared[0], datared[1], datared[2]);
                    }
                    datared.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
