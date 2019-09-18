using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starter code for lab 2
           double height = 0;
            double steps = 0;
            double miles = 0;

            Console.WriteLine("enter your height in inches");
           height = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your steps");
            steps = double.Parse(Console.ReadLine());


            miles = ((((height * .413)/12) * steps)/5280);
            Console.WriteLine("you walked " + miles + " miles");
            Console.ReadKey();
        }
    }
}
