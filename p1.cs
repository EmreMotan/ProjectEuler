/*
 * Emre Motan
 * 6/12/2014
 * 
 * Multiples of 3 and 5
 * Problem 1
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * CHALLENGE: Find the sum of all the multiples of 3 or 5 below 1000.
 * 
 * The idea is to find the multiples of three and five under 1000 and add them together. The trick is to not double add the numbers that
 * are multiples of both three and five otherwise the answer will be inflated and incorrect.
 * 
 * ANSWER: 233168
 */
namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    class P1
    {
        public void Run()
        {
            int n = 1000;

            // Accumulator
            int sum = 0;

            // Loop over every number less than n
            // If i is a multiple of three or five, add it to the accumulator. 
            // If i is a multiple of both three or five, only add it to the accumulator once.
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    continue;
                }

                if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of three and five below {0}: {1}", n, sum);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}