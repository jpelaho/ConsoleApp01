using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class feature001
    {
        public int A { get; set; }
        public int B { get; set; }
        public feature001(int a,int b)
        {
            A = a;
            B = b;
        }
        public int Add()
        {
            return A + B;
        }
    }
}
