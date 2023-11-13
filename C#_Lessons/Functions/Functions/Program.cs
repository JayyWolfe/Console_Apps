/*
Name: Jay
Class: Sci 20s
Description: This code deals with functions, mandatory and optinal parameters.
*/

using System.Xml;

namespace Functions
{
    public class FunctionsClass
    {
        /*
        //This is a function. A 'void' function doesn't return anything.
        //Void means empty return.
        //Write the name and parentheses to call the function.
        static void customMessage(String word) 
        {
            Console.WriteLine("*****"+word+"*****");
        }
        static int sum(int num1, int num2) //takes num1 and num2 and returns their sum.
        {
            return num1 + num2;
        } */

        static int product(int num1, int num2)
        {
            return num1 * num2;
        }


        static String toLowerOrUpper(String word, bool toLower)
        {

            if (toLower) 
            { 
                return word.ToLower(); 
            }

            else 
            { 
                return word.ToUpper(); 
            }
        
        }

        public static void Main()
        {
            /*
            Console.WriteLine("Enter a word.");
            String input = Console.ReadLine();
            //we call functions by their names and add () to it.
            //if the function takes input we put the input between the parentheses. 
            //passing the value of 'input' to the string 'word'.
            //a function executes everytime it is called.
            customMessage(input);
            customMessage(input);
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            Console.WriteLine("Enter the first number.");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            int second = Convert.ToInt32(Console.ReadLine());
            sum(first, second);
            int result = sum(first, second); //have to actually do something with what's being returned
            // ^^^^ when a function returns a value we can store that value in a variable to use it later
            Console.WriteLine("The sum is " + result);
            */


            /*
            Console.WriteLine("Enter the first number.");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            int second = Convert.ToInt32(Console.ReadLine());
            product(first, second);
            int result = product(first, second);
            Console.WriteLine("The product is " + result);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Enter a word.");
             string input = Console.ReadLine();
            String changedWord = toLowerOrUpper(input, false); //because it is false it converts everything to uppercase.
            //if it was true it would change everything to lowercase.
            Console.WriteLine(changedWord);



        }
    }
}