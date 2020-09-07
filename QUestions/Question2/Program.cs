using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUestions.Question2
{
    class Program
    {

        public enum GuessValidityStatus
        {
            GuessLessThanSecreteValue = -1,
            GuessEqualToSecreteValue = 0,
            GuessGreaterThanSecreteValue = 1,
        }

        //The System.Random provides us with a set of functions to get a random value
        private static readonly Random rand = new Random();
        public static int GetRandomInt(int min, int max)
        {
            return rand.Next(min, max);
        }

        public static int ValidateGuess(int guess)//This method is the verfy() 
        {
            //Checks wheather the guess value is equal, greater or smaller to the random value
            if (guess == randomSecreteValue)
            {
                return 0;
            }
            else if (guess > randomSecreteValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static void DoApp()
        {
            int i = 1;
            int highest = 1000000;
            int lowest = 0;
            int guess = 500000;
            do
            {
                Console.WriteLine("Secrete Random Value: {0}", randomSecreteValue);
                Console.WriteLine("Try number : {0}", i);
                guess = (int)((lowest + highest) / 2);
                Console.WriteLine("Computer said : My guess is ... {0}!!!", guess);
                var state = (GuessValidityStatus)ValidateGuess(guess);
                if (state == GuessValidityStatus.GuessGreaterThanSecreteValue)
                {
                    highest = guess;
                    Console.WriteLine("Invalid Guess :/");
                }
                else if (state == GuessValidityStatus.GuessLessThanSecreteValue)
                {
                    lowest = guess;
                    Console.WriteLine("Invalid Guess :/");
                }
                else
                {
                    //GuessValidityStatus.GuesEqualToSecreteValue
                    Console.WriteLine("Computer has guessed correctly with :{0} :)", guess);
                    break;
                }
                if (i == 50)
                {
                    Console.WriteLine("Computer has lost");
                }
                i++;
            } while (i < 51);
            Console.WriteLine("Game Over all 50 tries completed.");
        }


        public static int randomSecreteValue = GetRandomInt(1, 1000000);
        public static void Main(string[] args)
        {
            DoApp();
            Console.ReadKey();
        }
    }
}
