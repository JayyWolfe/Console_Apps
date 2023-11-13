using System;
namespace online
{
    public class compiler
    {

        static int sum(int num1, int num2)
        {
            return num1 + num2;
         }
        public static void Main()
        {
            Console.WriteLine("Enter the first integer.");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer.");
            int second = Convert.ToInt32(Console.ReadLine());
            int result = sum(first, second);
            Console.WriteLine(result);
        }
    }
}