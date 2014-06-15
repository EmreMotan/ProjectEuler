/*
 * Emre Motan
 * 6/13/2014
 * 
 * Largest prime factor
 * Problem 3
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * 
 * What is the largest prime factor of the number 600851475143 ?
 * 
 * ANSWER: 6857
*/
namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class P3
    {
        public void Run()
        {
            //long n = 600851475143;
            long n =   600851475143;
            //long n = 100;

            //Method1(n);

            //Method2(n);

            //Method3(n);

            Method4(n, n / 100000);
        }

        void Method1(long n)
        {

            long boundary = (long)n / 1000;
            //long boundary = (long)System.Math.Floor(System.Math.Sqrt(n));
            long greatest_factor = 0;

            Stopwatch watch = new Stopwatch();

            // Method 1 - Concise Loop
            watch.Start();
            for (long i = 1; i < boundary; i++)
            {
                if (isPrime(i) == true)
                {
                    if (n % i == 0)
                    {
                        greatest_factor = i;
                    }
                }
            }
            watch.Stop();

            Console.WriteLine("{0}", watch.Elapsed);
            Console.WriteLine("{0}", greatest_factor);

            Console.ReadLine();
        }

        void Method2(long n)
        {
            long boundary = (long)n / 100;

            Stopwatch watch = new Stopwatch();

            // Method 2 - Lists and Loops
            watch.Reset();
            watch.Start();
            List<long> primes = new List<long>();

            // Get all prime numbers below 1/2 of n
            for (long i = 1; i < boundary; i++)
            {
                if (isPrime(i) == true)
                {
                    primes.Add(i);
                }
            }

            List<long> factors = new List<long>();

            // Get all factors of n from list "primes"
            foreach (var prime in primes)
            {
                if (n % prime == 0)
                {
                    factors.Add(prime);
                }
            }

            watch.Stop();
            Console.WriteLine("{0}", watch.Elapsed);

            // Print max factor
            {
                Console.WriteLine("{0}", factors[factors.Count - 1]);
            }

            Console.ReadLine();
        }

        void Method3(long n)
        {
            Stopwatch watch = new Stopwatch();

            // Method 3 - Create list of all prime numbers under 1/2 of n
            watch.Reset();
            watch.Start();
            List<long> primes = new List<long>();

            long boundary = (long)(0.5 * n);

            for (long i = 1; i < boundary; i++)
            {
                if (isPrime(i) == true)
                {
                    primes.Add(i);
                }
            }
            watch.Stop();
            Console.WriteLine("{0}", watch.Elapsed);

            Console.WriteLine("Found all prime numbers under {0}", boundary);

            watch.Reset();
            watch.Start();
            long greatest_factor = 0;
            // Loop through all_primes and see if they are factors of n. Keep last one.
            foreach (var prime in primes)
            {
                if (n % prime == 0)
                {
                    greatest_factor = prime;
                }
            }

            watch.Stop();
            Console.WriteLine("{0}", greatest_factor);
            Console.WriteLine("{0}", watch.Elapsed);
            Console.ReadLine();
        }

        void Method4(long n, long boundary)
        {
            // Searching backward from boundary toward 0
            Console.WriteLine("\nMethod 4");

            Stopwatch watch = new Stopwatch();

            watch.Reset();
            watch.Start();

            long greatest_factor = 0;

            for (long i = boundary; i > 1; i--)
            {
                if (isPrime(i) == true && (n % i == 0))
                {
                    greatest_factor = i;
                    break;
                }
            }
            watch.Stop();
            Console.WriteLine("{0}", watch.Elapsed);

            Console.WriteLine("Found greatest factor: {0}", greatest_factor);
            Console.ReadLine();
        }

        public bool isPrime(long number)
        {
            long boundary = (long)System.Math.Floor(System.Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }
}
