/*
 * 
 * Emre Motan
 * 6/13/2014

 * Sum square difference
 * Problem 6
 * The sum of the squares of the first ten natural numbers is,
 * 
 * 1^2 + 2^2 + ... + 10^2 = 385
 * The square of the sum of the first ten natural numbers is,
 * 
 * (1 + 2 + ... + 10)2 = 552 = 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 * 
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 * 
 * ANSWER: 25164150
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
    public class P6
    {
        public void Run()
        {
            int n = 100;

            // Output first n natural numbers
            Console.WriteLine("\nFirst {0} natural numbers:", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }

            int sum_squares = 0;
            // Calculate sum of squares of first n natural numbers
            for (int i = 1; i <= n; i++)
            {
                sum_squares += i * i;
            }
            Console.Write("\nSum of squares: {0} ", sum_squares);

            int square_sums = 0;
            int sums = 0;
            // Calculate square of sum of first n natural numbers
            for (int i = 1; i <= n; i++)
            {
                sums += i;
            }
            square_sums = sums * sums;
            Console.Write("\nSquare of sums: {0} ", square_sums);

            Console.WriteLine("Difference between sums: {0}", square_sums - sum_squares);
            Console.ReadLine();
        }
    }
}
