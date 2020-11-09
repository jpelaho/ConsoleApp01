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
        public string Name { get; set; }
        public string SurName { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
     
}
