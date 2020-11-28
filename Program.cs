using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet user and get input 
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("How much do you want to convert to coins?");
            string totalAsString = Console.ReadLine();

            double total = Convert.ToDouble(totalAsString);
            Console.WriteLine($"{total} is equal to...");

            // Define coin values 
            int goldvalue = 10;
            int silverValue = 5;

            // Calculate the change 
            double goldCoins = Math.Floor(total / goldvalue);

            double remainder = total % goldvalue;

           

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            // print the results 
            Console.WriteLine($"Gold coins:{goldCoins}");
            
            Console.WriteLine($"Silver coins:{silverCoins}");
            
            
            Console.WriteLine($"Bronze coins:{remainder}");

   
            {
                
            }
            
        }
    }
}
