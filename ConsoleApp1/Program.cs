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
            feature001 feature = new feature001(5, 7);
            //Console.WriteLine("Enter a : ");
            //var a = Console.ReadLine();

            //decimal a1 = Convert.ToDecimal(a);
            //Console.WriteLine("Enter b : ");

            //var b = Console.ReadLine();
            //decimal b1 = Convert.ToDecimal(b);

            var jules = new User
            {
                Nom = "Pelaho",
                Prenom = "Jules"
            };
            Console.WriteLine(jules.NomLong());
            Console.WriteLine("c = a*b : {0}", feature.Add());
            Console.ReadLine();
        }
    }
}
