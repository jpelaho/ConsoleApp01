using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class feature002
    {
        public int A { get; set; }
        public int B { get; set; }
        public feature002(int a,int b)
        {
            A = a;
            B = b;
        }
        public int Multiply()
        {
            return A * B;
        }
    }
}
