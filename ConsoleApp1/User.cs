using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public int Age { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int AddFeature001()
        {
            feature001 feature = new feature001(1, 5);
            return feature.Add();
        }
        public String NomLong()
        {
            return Nom + " " + Prenom;
        }
    }
}
