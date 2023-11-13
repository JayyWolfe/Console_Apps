/*
 Name: Jay
Class: Comp Sci 20s
Description: this code reverses a word given to it by the user
 */
namespace ReverseWords
{
    public class reversewords
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();
            char[] chars = word.ToArray();
            Array.Reverse(chars);
            Console.Write("The word reversed is ");
            Console.WriteLine(chars);


        }
    }
}