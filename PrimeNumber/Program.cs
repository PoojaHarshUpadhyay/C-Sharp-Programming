using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //double n = 70000000;
            Random ran = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                double a = ran.Next(i);
                double n = i;
                bool isPrime = checkPrime(n, a);
                if (isPrime == true)
                {
                    Console.WriteLine("Number {0} is prime", n);
                }
                else
                {
                    Console.WriteLine("Number {0} is not prime", n);
                }
            }
            Console.ReadLine();
        }

        private static bool checkPrime(double n, double a)
        {
            if (n < 0 )
            {
                throw new ArgumentOutOfRangeException("Input should be greater than 0");
            }
            else if (n == 0 || n == 2 )
            {
                return true;
            }
            else
            {
                double tempVal = Math.Pow(a, n - 1);
                double result =  tempVal % n;
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
