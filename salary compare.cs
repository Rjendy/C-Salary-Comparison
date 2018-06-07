using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Peron1");
            Console.WriteLine("What's your hourly rate: ");
            decimal p1rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work in a week: ");
            decimal p1hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Peron2");
            Console.WriteLine("What's your hourly rate: ");
            decimal p2rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work in a week: ");
            decimal p2hours = Convert.ToInt32(Console.ReadLine());

            decimal weekly1 = p1rate * p1hours;
            decimal weekly2 = p2hours * p2rate;
            decimal annual1 = weekly1 * 52;
            decimal annual2 = weekly2 * 52;

            Console.WriteLine("Person1 Salary: " + annual1.ToString() + "\nPerson2 Salary: " + annual2.ToString());
            bool compare = annual1 > annual2;
            Console.WriteLine("Person1 makes more than Person2: " + compare);
            Console.ReadLine();
            

            
           


        }
    }
}
