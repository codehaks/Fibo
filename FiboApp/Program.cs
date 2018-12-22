using System;

namespace FiboAspApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(30); //warmup
            for (long i = 10; i < 50; i += 5)
            {
                var start = DateTime.Now;
                var f=Fibonacci(i);
                var duration = DateTime.Now - start;
                Console.WriteLine($"{i}-{f} => {(long)(duration).TotalMilliseconds}");
            }
        }

       static long Fibonacci(long number)
       {
          if (number == 0) { return 0; }
          else if (number == 1) { return 1; }
          else
          {
              var t1 = Fibonacci(number - 1);
              var t2 = Fibonacci(number - 2);
              return t1 + t2;
          }
       }

        // static long Fibonacci(long n)
        // {
            // long a = 0;
            // long b = 1;
            
            // for (long i = 0; i < n; i++)
            // {
                // long temp = a;
                // a = b;
                // b = temp + b;
            // }
            // return a;
        // }
    }
}
