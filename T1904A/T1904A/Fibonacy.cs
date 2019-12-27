using System;
namespace T1904A
{
    public class Fibonacy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();
          for (int i = 1;; i++)
          {
              if (n > Fibonacci(i) & n < Fibonacci(i + 1))
              {
                  Console.WriteLine(Fibonacci(i));
              }
          }
          
        }
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}