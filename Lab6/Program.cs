using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Welcome();


            while (true)
            {
                int nSides = ConvertToInt();
                int RollOne = GetRandomNumber(nSides);
                int RollTwo = GetRandomNumber(nSides);
                string SpecialMessage = DisplaySpecialMessages(RollOne, RollTwo);


                Console.WriteLine("Roll One: " + RollOne);
                bool SecondDice = AskToRollAgain();
                if (SecondDice == true)
                {
                    Console.WriteLine("Roll Two: " + RollTwo);
                }
                else
                {
                    break;
                }

                bool PlayAgain = AskToPlayAgain();
                if (PlayAgain == false)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }



            Console.WriteLine("Thank You for using Dice Roller!");

        }

        static bool AskToRollAgain()
        {
            Console.WriteLine( "Would you like to Roll gain? (y/n)");
            string response = Console.ReadLine();

            if (response.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool AskToPlayAgain()
        {
            Console.WriteLine("Would you like to Play gain? (y/n)");
            string response = Console.ReadLine();

            if (response.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Welcome()
        {
            Console.WriteLine("Hello, welcome to Dice Roller. This program will help you create your own dice.");
        }

        static int ConvertToInt ()
        {
            Console.WriteLine("Please enter the number of sides you would like your dice to have.");

            string UsersRequestedSides = Console.ReadLine();

            bool isItANumber = int.TryParse(UsersRequestedSides, out int nDiceSides);
            return nDiceSides;
        }
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(1, max);
            }
        }

        static string DisplaySpecialMessages(int FirstRoll, int SecondRoll)
        {
            if (FirstRoll == 1 && SecondRoll == 1)
            {
                return "What are the odds!?!? You Rolled a snake eyes!!!";
            }
            else if (FirstRoll == 6 && SecondRoll == 6) 
            {
                return "What are the odds!?!? You Rolled a boxcars!!!";
            }
            else
            {
               return " ";
            }
        }
    }
}
