/*
 Name: Jay
Class: Comp Sci 20s
Description: this code tells the user if a number is bewteen 0 and 10.
 */
using System.Collections;

namespace numbers
{
    public class range
    {
        public static void Main()
        {
            /*Console.WriteLine("Enter a sentence to be checked for bombs.");
            string check = (Console.ReadLine());
            string bomb = check.ToLower();
            if (bomb.Contains("bomb") == true)
            {
                Console.WriteLine("Bomb detected.");
            }
            else if (bomb.Contains("bomb") == false)
            {
                Console.WriteLine("Bomb not detected.");
            }*/

            Console.WriteLine("Enter a number to see if it is between 0 and 10.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (Enumerable.Range(0, 10).Contains(num))
            {
             Console.WriteLine("That number is between 0 and 10.");
            } 
            else
            {
                Console.WriteLine("That number is not between 0 and 10.");
            }
        }
        
    }
    
}
