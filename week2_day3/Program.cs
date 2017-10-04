using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE LOOPS
            //Set the variable outside the while
            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine().ToUpper();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play the game again? (YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            Console.WriteLine("Would you like to check in for your appointment?");
            string userAnswer = Console.ReadLine().ToUpper();

            while(userAnswer == "YES" || userAnswer == "NO" || userAnswer == "SURE")
            {
                Console.WriteLine("PATIENT CHECK IN SYSTEM:");
                Console.WriteLine("Please enter your name: ");
                string userName = Console.ReadLine().ToUpper();
                Console.WriteLine("Please enter your 6-digit patient ID: ");
                int userID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your appointment time (i.e. 2:00PM): ");
                string appointmentTime = Console.ReadLine();
                Console.WriteLine("Do you want to check in another patient: ");
                userAnswer = Console.ReadLine().ToUpper();
            }


            //DO WHILE LOOP
            //the variable is set outside of the loop so the vairable lasts for each loop
            //the DO section runs once
            //then as long as the While is true, then the DO will run again

            string playAgain;
            do
            {
                Console.WriteLine("Do you want to play a game? (Yes/No)");
                Console.WriteLine("The game has ended");
                Console.WriteLine("Would you like to play again? (Yes/No)");
                playAgain = Console.ReadLine().ToLower();
                //this ReadLine GIVES THE USER A CHANCE TO STOP
            }
            while (playAgain == "yes");
            //the WRITELINE Runs if the condition is not met.
            Console.WriteLine("Thanks for playing the game");
        }
    }
}
