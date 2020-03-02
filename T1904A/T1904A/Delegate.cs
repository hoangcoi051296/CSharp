using System.Threading;

namespace T1904A
{
    public delegate void PrimeNumberFinder(int n);
    public class Delegate
    {
        public event PrimeNumberFinder OnePrimeNumber;

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (isPrime(n)) {
                   
                } 
            }
            
            OnePrimeNumber o =new OnePrimeNumber();
            
        }
        
     
        public static boolean isPrime(int n) {
            if (n <= 1) {
                return false;
            }
            for (int i = 2; i <= Math.sqrt(n); i++) {
                if (n % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
    
}