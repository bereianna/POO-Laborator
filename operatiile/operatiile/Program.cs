using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatiile
{
    class Program
    {
        static void Main(string[] args)
        {
            Oper o = new Oper();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            o.Plus(n, m);
            o.Minus(n, m);
            o.Per(n, m);
            o.Ori(n, m);
        }
    }
}
