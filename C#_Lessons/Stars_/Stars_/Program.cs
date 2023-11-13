/*
Name: Jay
Class: Sci 20s
Description: This code takes an integer
then prints an asterisk triangle with a number of rows equal to the integer.
*/
namespace hello
{
    public class stars
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of rows in the aterisk triangle.");
            int rows = Convert.ToInt32(Console.ReadLine());
            int i, columns;
            for (i = 1; i <= rows; i++) // 'i' generates the numbers from 1 to whatever number 'rows' is set to
            {
                for (columns = 1; columns <= i; columns++)
                { // 'columns' deals with the coloumns. While it is less-
                    Console.Write("*        ");
                }//than or equal to 'i', it writes another columm-
                    Console.Write("\n");          //(This is my best interpretation of what I found on the internet)

            }            
        }
    }
}
    