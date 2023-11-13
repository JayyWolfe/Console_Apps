/*
Name: Jay
Class: Comp Sci 20s
Description: This code gives the user their regular pay, overtime pay and total pay based on their entry.
*/
namespace wages
{
    public class money
    {
        public static void Main()
        {
            /* Console.WriteLine("Enter the number of hours you worked.");
             double hoursworked = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter your hourly rate.");
             double hourlyrate = Convert.ToDouble(Console.ReadLine());
             double wage = hoursworked * hourlyrate;
             if (hoursworked > 40)
             {
                 double overtime = (hoursworked - 40);
                 double overtimepay = (overtime * 1.5 * hourlyrate);
                 double regularpay = (hoursworked * hourlyrate);
                 double totalpay = (overtimepay + regularpay);
                 Console.WriteLine("Your overtime pay is " + overtimepay);
                 Console.WriteLine("Your regular pay is " + regularpay);
                 Console.WriteLine("Your total pay is " + totalpay);
             }
             else
             {
                 double regularpay = (hoursworked * hourlyrate);
                 Console.WriteLine("You have no overtime pay.");
                 Console.WriteLine("Your regular pay is " + regularpay);
                 Console.WriteLine("Your total pay is " + regularpay);
             } */



            Console.WriteLine("Enter the number of hours you worked");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your wage.");
            double wage = Convert.ToDouble(Console.ReadLine());
            double otHours = 0;
            double otPay = 0;
            if (hours > 40)
            {

                otHours = hours - 40;
                otPay = otHours * 1.5 * wage;
            }

            double regPay = 40 * wage;
            double totalPay = regPay + otPay;
            Console.WriteLine("Your regular pay is " + regPay);
            Console.WriteLine("Your overtime pay is " + otPay);
            Console.WriteLine("Your total pay is " + totalPay);
           
      
        }
    }
}