using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program5
    {
        static void Main()
        {
            double a = 5.2;
            double b = a * 2;
            //System.Console.WriteLine("a = " + a);
            //System.Console.WriteLine("b = " + b);
            //System.Console.WriteLine("a = " + a + ", b = " + b);

            //Placeholder
            Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine("a = {1}, b = {0}", a, b); // this is OK
            //Console.WriteLine("a = {1}{0}{1}{0}{1}{1}{1}, b = {0}", a, b); //this is OK
            Console.WriteLine("a = {0}, b = {1}", a, b, 100, 200);
            //Console.WriteLine("a = {0}, b = {2}", a, b); //not OK

            //Console.WriteLine("Hello " + " World!");
            //Console.WriteLine("Hello " , " World!");

        }
    }
}
