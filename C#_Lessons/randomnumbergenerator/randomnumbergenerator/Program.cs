/*
Name: Jay
Class: Comp Sci 20s
Description: This code generates a random number from 1 to 10 and asks the user to guess it.
*/
using System;
using System.ComponentModel.Design;

namespace generator
{
    public class numbers
    {
        public static void Main()
        {
            Console.WriteLine("This generator will generate a random number from 1 to 10.");
            Random r = new Random();
            int rInt = r.Next(1, 10);
           
            Console.WriteLine("Guess the number.");
            int guess = Convert.ToInt32(Console.ReadLine());
            while ((guess == rInt) == true) 
            {
                Console.WriteLine("Your guess was correct. The number was " + rInt);
            }
             while ((guess == rInt) == false)
            {
                Console.WriteLine("Your guess was incorrect.");
            }
        }
    }
}