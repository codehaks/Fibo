using System;
using System.Collections.Generic;
using System.Linq;

namespace FiboAspApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ; //warmup
              //for (long i = 10; i < 50; i += 5)
              //{
              //    var start = DateTime.Now;
              //    var f=Fibonacci(i);
              //    var duration = DateTime.Now - start;
              //    Console.WriteLine($"{i} => {(long)(duration).TotalMilliseconds} - {f}");
              //}


            var list = new List<long>();// { 0, 1 };
            //Fibonacci2(ref list, 30);

            for (long i = 0; i < 50; i++)
            {
                var start = DateTime.Now;
                var f = Fibonacci2(ref list,i);
                var duration = DateTime.Now - start;
                Console.WriteLine($"{i} => {(long)(duration).TotalMilliseconds} - {f}");
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

  

        static long Fibonacci2(ref List<long> fiboList, long number)
        {
            long result = 0;

            if (number == 0) { result= 0; }
            else if (number == 1) { result = 1; }
            else
            {
                result = fiboList[fiboList.Count - 1] + fiboList[fiboList.Count - 2];
            }
            
            fiboList.Add(result);
            return result;
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
