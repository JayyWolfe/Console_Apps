/*
 Name: Jay
Class: Comp Sci 20s
Description: this code deals with loop statements
 */
namespace loops
{
    public class statements
    {
        public static void Main()
        {
            /* int counter = 10;
        start: //this is a label, can be any text/word
            Console.WriteLine(counter);
            counter = counter - 1;
            if (counter >= 1)
            {
                goto start; //going back to the label, back to the start/begining
            } */

            /* int counter = 1; //better way of doing a loop, condition must be true for the loop to work
            while (counter >= 1) //this condition must be true for the loop to work at all.
                //the condition must become false at some point to prevent an infinite loop.
            {
                Console.WriteLine(counter);
                counter++;
            } */
            bool keepRunning = true;
            string decision = "n";
            while (keepRunning)
            {
                Console.WriteLine("This loop is running");
                Console.WriteLine("Do you want to stop it? Press y for yes or n for no.");
                decision = Console.ReadLine();
                if(decision == "y") { keepRunning = false; }
            }
            //do while loops will always work at least one time because it performs the action first then checks the condition.
            /* do
            {
                Console.WriteLine("This loop is working");
            } while (1 > 2); //regardless of whether the condition is true or false the loop will work once.
            //will work once
            //the condition needs to be true to run it more than once. */
            /* int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 10); */
            //initialization is 1=10
            //boolean expression is i<100
            //update is i += 10 which means i = i + 10
            //the loop will continue working as long as the boolean expression is true
            /* for (int i = 10; i <= 100; i += 10) //'=' declares and initializes the loop variable, '<' is the loop condition, 'i++' changes the loop variable after each cycle
            {
                Console.WriteLine(i); //from 10 to 100 in increments of 10
            }
            for (int i = 10; i >= 1; i--) //from 10 to one
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i >= 1; i++) //from one to infinity, is infinite because the statement never becomes false
            {
                Console.WriteLine(i);
            } */

            /*String[] names = { "Greg", "Mann", "Magnus", "Martin", };
            for (int i = 0; i<names.Length; i++) // prints all of the names on different lines
            {
                Console.WriteLine(names[i]);
            }
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }*/
            /* int[] numbers = { 10, 20, 30, 100 };//prints all of the numbers on different lines
            for (int i = 0; i<numbers.Length; i++)//more tedious than the other way
            {
                Console.WriteLine(numbers[i]);
            }
            foreach(int number in numbers) //easier than this line ^^^
            {
                Console.WriteLine(number);
            } */
        }
    }
}
