using System;
using System.Threading;

namespace T1904A
{
    public class Lab4
    {
        static void Main(string[] args)
        {
        Thread t1 =new Thread(hhh);
        t1.Start();
        }

        public static void hhh()
        {
            for (int i = 9; i >= 0; i--)
            {
                try
                {
                    for (int j = 59; j >= 0; j--)
                    {
                        try
                        {
                            if (j < 10)
                            {
                                Console.WriteLine(i + ":" + "0" + j);
                            }
                            else
                            {
                                Console.WriteLine(i + ":" + j);
                            }

                            Thread.Sleep(1000);
                            if (i == 0 && j == 0)
                            {
                                Console.WriteLine("BB");
                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}