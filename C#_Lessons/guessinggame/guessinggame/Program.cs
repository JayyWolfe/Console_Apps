/*
 Name: Jay
Class: Comp Sci 20s
Description: this code generates a random
number between 1 and 10 , then asks the user to guess the number.
The program will continue until the correct number is guessed.
 */

using System.ComponentModel.Design;

namespace game
{
    public class guess
    {
        public static void Main()
        {
            bool keepRunning = true; 
            Console.WriteLine("Guess a number between 1 and 10.");
            
                

                Random random = new Random();
                int randomnumber = random.Next(1, 10);
                
                while (keepRunning)
                {   
                    int answer = Convert.ToInt32(Console.ReadLine());

                    if (answer < randomnumber)
                    {
                        Console.WriteLine("Too low, try again.");
                        
                       
                    }
                    else if (answer > randomnumber)
                    {
                        Console.WriteLine("Too high, try again.");
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("That was the correct number.");
                        keepRunning = false;
                      
                    }

                }
             
        }
    }
}