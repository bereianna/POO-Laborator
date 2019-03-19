using System;
namespace operatiile
{
    public class Oper
    {
        public void Plus(int a, int b)
        {
           
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
        }

        public void Per(int a, int b)
        {
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
        }

        public void Minus(int a, int b)
        {
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
        }

        public void Ori(int a, int b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        }
    }
}