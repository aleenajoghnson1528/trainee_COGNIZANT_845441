using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //provider

namespace CONNETIONTODATABASE
{
    class Program
    {
        static void Main(string[] args)
        {
            //  student1();
            // employee1();
            //  sqlserverdatredemo();
            // insertintotable();

            // Restauranttableinsertdata();

            //  menutableinsert();

            //  menutableinsertvalue2();


            /*   Restaurantclass obj = new Restaurantclass();
               obj.insertdata();
               obj.display();  */


           // insertdataintotable();

             // updaterestauranttable();
           selectrow();
        }

       private static void selectrow()
        {
            restaurantdatalayer d2 = new restaurantdatalayer();
            d2.ShowRestaurant(0);
        }
          
        private static void updaterestauranttable()
        {
            restaurantdatalayer d1 = new restaurantdatalayer();
            d1.UpdateLocation(1, "tirur");
            d1.ShowAllRestaurants();
        }

        private static void insertdataintotable()
        {
            Restaurant rt = Setdata();
            restaurantdatalayer rd1 = new restaurantdatalayer();
            rd1.InsertRestaurant(rt);
            List<Restaurant> localliststr = rd1.ShowAllRestaurants();


            foreach (var s in localliststr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.Id, s.Rname, s.Rloc, s.Rating);
            }
        }

        public static Restaurant Setdata()
            {

            Console.WriteLine("enter id:");
              int id = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter restaurant name:");
                string rname = Console.ReadLine();
                Console.WriteLine("enter location:");
                string location = Console.ReadLine();
                Console.WriteLine("enter rating:");
                int rting= Convert.ToInt32(Console.ReadLine());
                Restaurant rts = new Restaurant();
                rts.Rating = rting;
                rts.Rname = rname;
                rts.Rloc = location;
                 rts.Id = id;

                return rts;
            }

        

        private static void menutableinsertvalue2()
        {
            string constr1 = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=restaurant;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr1))
            {
                string insertquery1 = "insert into Menu (Restaurant_name,item,price) values (" + " 'thamburan' " + " , " + " 'kerala rice' " + " , " + " '250')";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertquery1, con);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }

        private static void menutableinsert()
        {
            string constr = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=restaurant;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string insertquery = "insert into Menu (Restaurant_name,item,price) values (" + " 'ustad hotel' " + " , " + " 'chicken biriyani' " + " , " + " '250')";
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

        private static void Restauranttableinsertdata()
            {
                string constr = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=restaurant;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string insertquery = "insert into Restaurant_table(Res_name,place,customer_rate) values (" + "'ustad hotel'" + "," + "'chennai'" + "," + "'5')";

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

            private static void insertintotable()
            {
                string constr = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=student;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string insertquery = "insert into department(Did,Dname) values(" + "'104'" + "," + "'IT')";
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

            private static void sqlserverdatredemo()
            {
                string constr = @"Data Source=BLT1059\SQLEXPRESS2014;Initial Catalog=student;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string querystr = "select * from coursetable";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(querystr, con);
                        SqlDataReader datared = cmd.ExecuteReader();
                        while (datared.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", datared[0], datared[1], datared[2], datared[3]);
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

            private static void employee1()
            {
                string constr = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = ALEENA; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    try
                    {
                        string querystr = "select *from employee";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(querystr, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadKey();
                }
            }

            private static void student1()
            {
                string constr = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = ALEENA; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    try
                    {
                        string querystr = "select *from student";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(querystr, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                        }
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
