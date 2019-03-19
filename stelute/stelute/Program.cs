using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stelute
{
    class Program
    {
        static void Main(string[] args)
        {
            Stelu S = new Stelu();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Stelu.Write(n);
        }
    }
}
