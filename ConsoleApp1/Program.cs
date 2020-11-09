using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a : ");
            var a = Console.ReadLine();

            decimal a1 = Convert.ToDecimal(a);
            Console.WriteLine("Enter b : ");

            var b = Console.ReadLine();
            decimal b1 = Convert.ToDecimal(b);

            Console.WriteLine("c = a*b : {0}", a1 * b1);
            Console.ReadLine();
        }
    }
}
