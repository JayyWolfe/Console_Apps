/* 
Name: Jay
Class: Comp Sci 20s
Description: this code deals with switch statements which are conditional statements
*/
namespace Switch_Statements
{
    public class Switches
    {
        public static void Main()
        {
           /* Console.WriteLine("Enter a number between one and twelve.");
            int num = Convert.ToInt32(Console.ReadLine());
            /* if (num == 1)
            {
                Console.WriteLine("The month is january.");
            }
            else if (num == 2)
            {
                Console.WriteLine("The month is february.");
            }
            else if (num == 3)
            {
                Console.WriteLine("The month is march.");
            }
            else if (num == 4)
            {
                Console.WriteLine("The month is april.");
            } // takes too long.
            */
            // switch helps us compare one variable to multiple other cases.
            //Here the variable month is compared to multiple other cases.
            /* switch(num)
            {
                case 1: //in the case that a one is entered, "January" will be printed.
                    Console.WriteLine("January.");
                    break; //Break is needed to break out of the swtich.
                case 2:
                    Console.WriteLine("February.");
                    break;
                case 3:
                    Console.WriteLine("March.");
                    break;
                case 4:
                    Console.WriteLine("April.");
                    break;
                case 5:
                    Console.WriteLine("May.");
                    break;
                case 6:
                    Console.WriteLine("June.");
                    break;
                case 7:
                    Console.WriteLine("July.");
                    break;
                case 8:
                    Console.WriteLine("August.");
                    break;
                case 9:
                    Console.WriteLine("September.");
                    break;
                case 10:
                    Console.WriteLine("October.");
                    break;
                case 11:
                    Console.WriteLine("November.");
                    break;
                case 12:
                    Console.WriteLine("December.");
                    break;
                default: // only executes if all the above cases are false (if none of the cases match the entered number).
                    Console.WriteLine("Invalid input.");
                    break;
                    */
            Console.WriteLine("Enter your name to find out your grade.");
            String name = Console.ReadLine();
            switch (name.ToLower())
            {
                case "greg":
                    Console.WriteLine("85%");
                    break;
                case "magnus":
                    Console.WriteLine("100%");
                    break;
                case "mann":
                        Console.WriteLine("78%");
                    break;
                case "lochlan":
                Console.WriteLine("50%");
                    break;
                default:
                    Console.WriteLine("I've never met you in my life");
                    break;



            }




            }



        }
    }
}