using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtest
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] Int_array = new int[size];
            int[] Reverse_array = new int[size];
            for(int i=0;i<size;i++)
                {
                Console.Write("{0}", i + 1);
                Int_array[i] = int.Parse(Console.ReadLine());
            }

            Reverse_array = Task_13.Reverse_arrayy(Int_array, size);
            Console.WriteLine("input array:" + string.Join(",", Int_array));
            Console.WriteLine("output array:" + string.Join(",", Reverse_array));





            Sum(Int_array);







            /*   StringBuilder stb = new StringBuilder("hello");
               Console.WriteLine(stb);
               stb.Append(23445);
               Console.WriteLine("appended values{0}", stb);
               int i = stb.Capacity; //initial capacity of a string is 60
               Console.WriteLine("initial capacity of stringbuilder is {0}", i);
               stb.Insert(6, "world");
               Console.WriteLine("inserted at 6 is {0}", stb);
               stb.Remove(7, 4);
               Console.WriteLine("after removing {0}", stb);
               stb.Replace("lo", "arious");
               Console.WriteLine("after replacing {0}", stb);
               stb.Clear();
               Console.WriteLine("after clearing {0}", stb); */



            /* string[] s = new string[] { "aleena", "anand", "adarsh" };    //task 10 by direct input
             Stringnew(s); */


            /* string[] str = new string[10];                                            //task10 by user input
             Console.WriteLine("Task10 : Join Array Elements\nEnter string array elements: ");
             for (int i = 0; i < 3; i++)
             {
                 Console.Write("{0}. ", i + 1);
                 str[i] = Console.ReadLine();
             }
             Console.WriteLine("{0}", Program.Stringnew(str));   */

            /*  Console.WriteLine("\nTask11 : Join The First and Last Name\nEnter your First name:");   //task 11 by user input
              string[] names = new string[2];
              names[0] = Console.ReadLine();
              Console.WriteLine("Enter your last name: ");
              names[1] = Console.ReadLine();
              string full_name = Program.Fullname(names);
              Console.WriteLine("Full name : {0}", full_name);*/

            /*   string st="aleena johnson";    //task12

               string[] newst = Program.splitstr(st);

               foreach (string s in newst)
               {
                   Console.WriteLine(s);
               }
                */

            /*   string strlong = "hello hw r u?iam fine, what abou u";  // spli based on delimitors
               string[] sts = strlong.Split('?', ',');
               foreach(string st in sts)
               {
                   Console.WriteLine(st);
               }
               */


            /* int[] array = { 1, 2, 3 };

             foreach (int value in array)
             {
                 Console.WriteLine(value);
             }
             Console.WriteLine();
             Array.Reverse(array);
             foreach (int value in array)
             {
                 Console.WriteLine(value);
             }
              */


            /*     int[] str = new int[5] { 1, 2, 3, 4, 5 };                                        //task10 by user input

                  for (int i = str.Length-1; i >=0; i++)
                  {
                     Console.WriteLine(str[i]);

                  }
                 int[] newst= Program.Stringnew1(str);
                 for (int i=0; i<newst.Length; i ++)
                 {
                     Console.WriteLine(newst[i]);
                 }

                 */

            /*  Console.WriteLine("Given an array of ints, write a C# method to total all the values that are even numbers.(using LinQ)");

              int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

              Console.WriteLine(TotalAllEvenNumbers(intArr).ToString()); */

            /*    string fn;                                  //task 11 by direct argument passing
                string ln;
                Console.WriteLine("enter your first name:");
                fn = Console.ReadLine();
                Console.WriteLine("enter your last name:");
                ln = Console.ReadLine();
                display(fn,ln);


                string st1 = "hello aleena johnson";    // task 12 by direct argument passing
                Stringtest(st1); */


        }

        public static void Sum(int[] Int_array)
        {
            int total_sum = 0;
            for (int i = 0; i < Int_array.Length; i++)
            {
                if (Int_array[i] % 2 == 0)
                {
                    total_sum = total_sum + Int_array[i];

                }
            }
            Console.WriteLine(total_sum);

        }



        /*  public static void Stringnew(string[] str)                         // task 10 by direct argument
          {
              string allnames = string.Join(",", str);
              Console.WriteLine("string after joining is{0}", allnames);
          }
           */




        /*
                  public static void display(string fn, string ln)   //task 11 by direct passing argument
                  {
                      string result = string.Concat(fn, ln);
                      Console.WriteLine("fullname is {0}", result);
                  }



                 public static void Stringtest(string st2)   // task 12 by direct value passing
                  {
                      string[] word = st2.Split();
                      foreach(string s in word)
                      {
                          Console.WriteLine(s);
                      }

                  } */



        /*  public static string Stringnew(string[] str)     //task 10 by user input
          {
              string str1 = string.Join(" ", str);
              return str1;
          }  */
        /*    public static int[] Stringnew1(int[] str)     //task 10 by user input
           {
                int i = 0;
                int j = str.Length - 1;
                while (i < j)
                {
                    var temp = str[i];
                    str[i] = str[j];
                    str[j] = temp;
                    i++;
                    j--;
                }
                return str; 
            }
            */
        /*    static long TotalAllEvenNumbers(int[] intArray)
            {
                return (from i in intArray where i % 2 == 0 select (long)i).Sum();
            } */

        /*  public static string Fullname(string[] names)  //task 11 by user input
          {
              return string.Join(" ", names);
          }
          */


        /*  public static string[] splitstr(string st)  //tsk 12
          {
              return st.Split();
          }
            */

    }
}
