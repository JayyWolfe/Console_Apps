/*
 Name: Jay
Class: Comp Sci 20s
Description: this code takes an upper
bound, then adds all the integers between 0 and that upper bound.
 */
namespace bounds
{
    public class addtill
    {
        public static void Main()
        {
            Console.WriteLine("Enter the upper bound.");
            int upperbound = Convert.ToInt32(Console.ReadLine()); //'example++' only adds one onto the given number.
            int total = 0;
            for (int i = 0; i <= upperbound; i++)
            {
                Console.WriteLine(i);
                total = (total + i);
            }

            Console.WriteLine("The sum of those numbers is " + total);

        }
    }
}