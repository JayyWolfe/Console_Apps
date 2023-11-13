/*
 Name: Jay
Class: Comp Sci 20s
Description: this code finds the average score between three scores
 */
namespace scores
{
    public class testscores
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the first test score.");
            double num0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second test score.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third test score.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num0 + num1 + num2;
            double average = sum / 3;
            Console.WriteLine("The average score is " + average);


        }
    }
}