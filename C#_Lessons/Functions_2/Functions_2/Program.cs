/*
Name: Jay
Class: Sci 20s
Description: This code deals with functions, mandatory and optinal parameters.
*/
namespace Functions2
{
    public class second
    {
        static void burgerOrder(String food, bool extraCheese=false)
        {
         
        }
        static void customMessage(String word, bool showStars=false) // parameters = input
         //when writing the function, if the variable does not have an initial value like String word, it is mandatory.
         //if the variable has an initial value like bool showStars=false,
         //then it is optinal.
            //if given an initial value it is an optional parameter; if it doesn't have an initial value it is mandatory.
            //with optional input, if the user sends an input,
            //the variable will use the user's input
            //if the user does not send anything,
            //the variable will use the intial(default) value.
        {
            if (showStars)
            {


                Console.WriteLine("****" + word + "****");
            }
            else
            {
                Console.WriteLine(word);
            }
        }
        public static void Main()
        {
            /*
            Console.WriteLine("Enter a word.");
            String input = Console.ReadLine();
            customMessage(input);
            customMessage(input, showStars: true); */
            
            Console.WriteLine("Enter your order.");
            String order = Console.ReadLine();
            Console.WriteLine("Do you want extra cheese?");
            String choice = Console.ReadLine();
            string choice2 = choice.ToLower();
            burgerOrder(order);
            if (choice2.Contains("yes") == true)
            {
                
                Console.WriteLine("Your order is '" + order + "' with extra cheese.");
            }
            else
            {
                Console.WriteLine("Your order is '" + order + "'. You did not order extra cheese.");
            }

           




        }
    }
}