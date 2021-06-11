using System;

namespace nowyAnnaMusial
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();
            Console.WriteLine("Czesc i czolem");
            for(int i=0;i<10;i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(rand.Next(100,999));
            }
        }
    }
}

