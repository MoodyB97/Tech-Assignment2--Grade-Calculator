// Author: Benjamin Moody
//  Date: 9/14/2021
// Comments: This C# program will use If Else statements to calculate a students grade in ISM 4300
using System;

namespace Tech_Assignment2__Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your anticipated grade in ISM 4300");
            //This writes a message to the user to enter their anticipated grade
            try
            {
                // This will grab the users integer input
                string input = Console.ReadLine();

                //Stores the users entry as the variable score
                double score = double.Parse(input);

                if (score > 89.5)
                    { Console.WriteLine("You got a A");
                }
                else if (score > 79.5)
                { Console.WriteLine("You got a B");
                }
                else if (score > 69.5)
                { Console.WriteLine("You got a C");
                }
                else if (score > 59.5)
                { Console.WriteLine("You got a D");
                }
                else 
                
                    Console.WriteLine("You got an F...");
                }
               //This checks the user inputs and determines which grade the student shall recieve  
            catch
            {
                Console.WriteLine("Plese enter a valid score");
            }
            //This accounts for user data entry errors
            
        }
    }
}
