using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Train : Roadwayvehicle
    {
        public void ShowTrain()
        {
            Console.WriteLine(" train ");
        }

        public override void Show()
        {
           // base.Show();
            Console.WriteLine("train track is perfect");
        }
    }
}
