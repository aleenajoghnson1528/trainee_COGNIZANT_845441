using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CONNETIONTODATABASE
{
    class restaurantdatalayer
    {
        private string constr = " ";
        public restaurantdatalayer()
        {
            constr = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=aleenaj;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public void UpdateLocation(int id,string location)
        {
            string updatequery="update Res set Rloc="+" ' " +location + " ' " + "where id=" + id;
            int i = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(updatequery, con);
                    i = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if(i>0)
                {
                    Console.WriteLine("location updated");
                }
                       
            }
        }
        public Restaurant ShowRestaurant(int id)
        {
            string singlerowquery = "select * from Res where ID=1";
            Restaurant rtnt;
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(singlerowquery, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        rtnt = new Restaurant {// Id = Convert.ToInt32(dr[0],
                            Rname = dr[1].ToString(),
                            Rloc = dr[2].ToString(),
                            Rating = Convert.ToInt32(dr[3])
                            };
                    }
                   
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return rtnt;

            }
        }  
        
        public void InsertRestaurant(Restaurant rt)
        {
            string insertquery = string.Format("insert into Res values( '{0}',' {1}',' {2}','{3}');",rt.Id, rt.Rname, rt.Rloc, rt.Rating);
            using (SqlConnection con = new SqlConnection(constr))
            {
                int i = 0;
                con.Open();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand(insertquery, con);
                    i = cmd.ExecuteNonQuery();

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if(i>0)
                {
                    Console.WriteLine("inserted");
                }
            }
        }
        public List<Restaurant> ShowAllRestaurants()
        {
            var reslist = new List<Restaurant>();
            string selectquery = "select * from Res";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        reslist.Add(new Restaurant
                        {
                             Id = Convert.ToInt32(dr[0]),
                            Rname = dr[1].ToString(),
                            Rloc = dr[2].ToString(),
                            Rating = Convert.ToInt32(dr[3])
                        });
                    }
                }




                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return (reslist);
            }


        }
    }
}
