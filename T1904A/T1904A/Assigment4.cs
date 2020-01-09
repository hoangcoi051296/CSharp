using System;
using System.Threading;

namespace T1904A

{
    public class Assigment4
    {
        private static int n;
        static void Main(string[] args)
        {    Console.WriteLine("Nhap n"); 
            n = Convert.ToInt32(Console.ReadLine());
            Thread t2 =new Thread(Ooo);
            t2.Start();
            Thread t1 =new Thread(hhh);
            t1.Start();
            
          
        }

        public static void hhh()
        {  
            try
            {
                for (int i = 1;; i++)
                {
                    if (Fibonacci(i) < n)
                    {
                        Thread.Sleep(100);
                    }
                    if (n > Fibonacci(i) & n < Fibonacci(i + 1))
                    {
                       

                        Console.WriteLine(Fibonacci(i));

                    }
                }

            }catch (Exception e) { }
            static int Fibonacci(int n)
            {
                if (n == 1 || n == 2)
                    return 1;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
                
            }
        
            
        }
        public static void Ooo()
        {
            int a = 0;
            try
            {
                for (int i = 1;; i++)
                {
                    if (Fibonacci(i) < n)
                    {
                        Thread.Sleep(100);
                        a=a+100;
                        Console.WriteLine(a+"ms");
                    }
                    
                }
                        
                   
                
               
                
            }catch (Exception e) { }
            static int Fibonacci(int n)
            {
                if (n == 1 || n == 2)
                    return 1;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        
            
        }
        
    }
}