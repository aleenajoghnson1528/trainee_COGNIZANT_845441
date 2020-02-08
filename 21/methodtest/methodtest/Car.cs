using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Car
    {
        string regno;
        string model;
        string color;
        double price;



        public Car() { } //default  constructor
        
            public Car(string reg) //overloaded constructor
            {
                regno = reg;
            }
             public Car(string reg, string mod)
            {
                regno= reg;
               model=mod;
             }
        public Car(string reg, string mod, string colr, double pr)
         {
           regno = reg;
           model = mod;
           color = colr;
           price = pr;
    }
  //  public void Showcar()
  public string Showcar()

    {
            return string.Format("Reg no : {0} \n model :{1} \n color : {2} \n price :{3}", regno, model, color, price);
        /* Console.WriteLine("reg no is " + regno);
        Console.WriteLine("model is" + model);
        Console.WriteLine("color is {0} and price is {1} " ,color,price); */ 

    }
    }
}
