using System;
namespace drept
{
    public class Dreptungi
    {
        public int Inaltime;
        public int Latime;
        public int ty=0;
        public Dreptungi(int n, int m)
        {
            Inaltime = n;
            Latime = m;
        }
        public void Aria()
        {
            Console.WriteLine("Aria={0}", Inaltime + Latime);
        }
    }
}