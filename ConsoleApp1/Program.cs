﻿using System;
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
            var feature = new feature001(5, 7);
            var feature2 = new feature002(5, 7);
            //Console.WriteLine("Enter a : ");
            //var a = Console.ReadLine();

            //decimal a1 = Convert.ToDecimal(a);
            //Console.WriteLine("Enter b : ");

            //var b = Console.ReadLine();
            //decimal b1 = Convert.ToDecimal(b);

            Console.WriteLine("c = a+b : {0}", feature.Add());
            Console.WriteLine("c = a*b : {0}", feature2.Multiply());
            Console.ReadLine();
        }
    }
}
