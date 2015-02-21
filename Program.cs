using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Loop
{
    class Program
    {
        public static Stopwatch watch = new Stopwatch();

        public static long fibonacciLoop(long girdi)
        {

            long fib1 = 1;
            long fib2 = 1;
            long gecici = 0;
            while (2 < girdi)
            {
                gecici = fib1 + fib2;
                fib1 = fib2;
                fib2 = gecici;
                girdi = girdi - 1;
            }
            return gecici;

        }
        static void Main(string[] args)
        {
            long deger = 0;
            Console.WriteLine("Kaçıncı fibonacci sayısını hesaplamak istiyorsunuz: ");
            deger = Convert.ToInt32(Console.ReadLine());
            watch.Start();
            Console.WriteLine("{0} . Fibonacci: {1}", deger, fibonacciLoop(deger));
            watch.Stop();
            Console.WriteLine("Gecen sure: {0} ", watch.Elapsed.ToString());

            Console.ReadLine();
        }
    }
}
