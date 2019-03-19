using System;

namespace stelute
{
    internal class Stelu
    {
        internal static void Write(int n)
        {
            for (int j = 1; j <= n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}