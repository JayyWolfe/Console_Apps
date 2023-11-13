
/*
 Name: Jay
Class: Comp Sci 20s
Description: this code tells the user what the largest of three enetered numbers is.
 */
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace evenodd
{
    public class numbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first number.");
            double num0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number.");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double[] arr = new double[] { num0, num1, num2};
            Array.Sort(arr);
            if (num0 > num1 & num0 > num2) { Console.WriteLine("The first number is the largest."); }
            if (num1 > num0 & num1 > num2) { Console.WriteLine("The second number is the largest."); }
            if (num2 > num0 & num2 > num1) { Console.WriteLine("The third number is the largest."); }



        }
    }
}