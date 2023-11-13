/*
 Name: Jay
Class: Comp Sci 20s
Description: this code tells the user all of the odd numbers in a given range, then loops back to the beginning.
 */

using System;
using System.Collections;

namespace num
{
    public class range
    {
        public static void Main()
        {

        beginning:
            Console.WriteLine("Enter the upper range.");
            int upperrange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower range.");
            int lowerrange = Convert.ToInt32(Console.ReadLine());
            IEnumerable<int> oddNums =
           Enumerable.Range(lowerrange, upperrange).Where(x => x % 2 != 0);

            foreach (int n in oddNums)
            {
                Console.WriteLine(n);
            }
            goto beginning;

        }
    }
}




