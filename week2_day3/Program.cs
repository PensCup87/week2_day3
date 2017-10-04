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

            //Console.WriteLine("Would you like to check in for your appointment?");
            //string userAnswer = Console.ReadLine().ToUpper();

            //while (userAnswer == "YES" || userAnswer == "NO" || userAnswer == "SURE")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM:");
            //    Console.WriteLine("Please enter your name: ");
            //    string userName = Console.ReadLine().ToUpper();
            //    Console.WriteLine("Please enter your 6-digit patient ID: ");
            //    int userID = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter your appointment time (i.e. 2:00PM): ");
            //    string appointmentTime = Console.ReadLine();
            //    Console.WriteLine("Do you want to check in another patient: ");
            //    userAnswer = Console.ReadLine().ToUpper();
            //}


            //DO WHILE LOOP
            //the variable is set outside of the loop so the vairable lasts for each loop
            //the DO section runs once
            //then as long as the While is true, then the DO will run again

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to play a game? (Yes/No)");
            //    Console.WriteLine("The game has ended");
            //    Console.WriteLine("Would you like to play again? (Yes/No)");
            //    playAgain = Console.ReadLine().ToLower();
            //    //this ReadLine GIVES THE USER A CHANCE TO STOP
            //}
            //while (playAgain == "yes");
            ////the WRITELINE Runs if the condition is not met.
            //Console.WriteLine("Thanks for playing the game");

            //DO IT SECTION

            //string classAdded;                   
            //string letterGrade;

            //do{
            //    Console.WriteLine("What class would you like to add to your GPA calculation?");
            //    string classAdded = Console.ReadLine().ToLower();
            //    Console.WriteLine("What is the letter grade for the class?");
            //    string letterGrade = Console.ReadLine().ToLower();
            //}
            //while (classAdded == "yes");

            //CONTINUE STATEMENTS
            //for (int i = 0; i < 20; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        continue;
            //        //CONTINUE stops loop at an even number and procedes to increment by 1, without printing
            //        //This program will output ODD NUMBERS ONLY
            //    }
            //    Console.WriteLine(i);
            //}

            //BREAK STATEMENTS
            //Ends all LOOP Activites

            //for (int i = 1; i <= 20; i++)
            //{

            //    if (i % 13 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("This loop has finished.");


            ////NESTED LOOPS
            ////inner most loops run first & FASTER
            ////Outermost Loop CANT RUN unless the Inner Loop Completes
            ////EFFECTIVE WAY TO PRINT ROWS AND COLUMNS (FOR A GAMEBOARD)

            //for(int i = 1; i <= 4; i++)
            //{
            //    for(int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j); //numbers the columns; VALUE HERE WILL BE DISPLAYED
            //    }
            //    Console.WriteLine(); // moves to the next row down
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for(int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}







        }
    }
}
