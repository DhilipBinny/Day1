using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program7
    {
        static void Main()
        {
            //Console.Write("Enter your name: ");

            ////OK
            //string name = Console.ReadLine();
            //Console.WriteLine($"Nice to meet you, {name}");

            ////NOT OK
            //string name="";
            //Console.ReadLine();

            ////OK but not recommended
            //Console.WriteLine($"Nice to meet you, {Console.ReadLine()}");

            Console.Write("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());

            //tax rate is 5%
            double tax = 0.05 * salary;
            Console.WriteLine($"Your tax is {tax}");


        }
    }
}
