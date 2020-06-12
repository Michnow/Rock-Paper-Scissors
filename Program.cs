using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Paper__Scissors__Rock
{
    class Program
    {
        private static int score;
        private static string input, rInput;

        static void Main(string[] args)
        {
            Menu();

        }
        static string Input()
            {
                Console.Write("Rock, Paper, Scissors, Lizard or Spock? ");
                return Console.ReadLine();
            }
        static bool ValidateString(string a)
            {
                List<string> ValidChars = new List<string> { "paper", "scissors", "rock", "lizard", "spock" };
                if (ValidChars.Contains(a.ToLower()))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again.");
                    return false;
                }
            }
        static string Draw()
            {
                Random random = new Random();
                int numb = random.Next(1, 5);
                string temp = String.Empty;
                switch (numb)
                {
                    case 1: temp = "Scissors"; break;
                    case 2: temp = "Paper"; break;
                    case 3: temp = "Rock"; break;
                    case 4: temp = "Lizard"; break;
                    case 5: temp = "Spock"; break;
                }
                return temp;
            }
        static string Game(string playerInput, string randomInput)
        {
            
            switch (playerInput+randomInput)
            {
                case "paperpaper":  return "Paper vs Paper. It's a draw!";
                case "paperscissors": score--; return "Your paper has been cut by scissors. You lose!";
                case "paperrock": score++; return "Your paper covers the rock. You win!";
                case "paperlizard": score--; return "Your paper has been eaten by Lizard. You lose!";
                case "paperspock": score++; return "Your paper disproves Spock. You win!";
                case "scissorspaper": score++; return "Your scissors has cut the paper. You win!";
                case "scissorsscissors": return "Scissors vs Scissors. It's a draw!";
                case "scissorsrock": score--; return "Your scissors has been crushed by rock. You lose!";
                case "scissorslizard": score++; return "Your scissors decapitates lizard. You win!";
                case "scissorsspock": score--; return "Your scissors has been smashed by spock. You lose!";
                case "rockpaper": score--; return "Your rock has been covered by the rock. You lose!";
                case "rockscissors": score++; return "Your rock crushes the scissors. You win!";
                case "rockrock": return "Rock vs Rock. It's a draw!";
                case "rocklizard": score++; return "Your rock  crushes the lizard. You win!";
                case "rockspock": score--; return "Your rock has been vaporized by the spock. You lose!";
                case "lizardpaper": score++; return "Your lizard eats paper. You win!";
                case "lizardscissors": score--; return "Your lizard has been decapitated by the scissors. You lose!";
                case "lizardrock": score--; return "Your lizard has been crushed by the rock. You lose!";
                case "lizardlizard": return "Lizard vs Lizard. It's a draw!";
                case "lizardspock": score++; return "Your lizard poisons the spock. You win!";
                case "spockpaper": score--; return "Your spock has been disproved by the paper. You lose!";
                case "spockscissors": score++; return "Your spock smashed the scissors. You win!";
                case "spockrock": score++; return "Your spock vaporizes the rock. You win!";
                case "spocklizard": score--; return "Your spock has been poisoned by the lizard. You lose!";
                case "spockspock": return "Spock vs Spock. It's a draw!";
                default:
                    return "Unexpected value. Try again";
            }
        }
        static void Menu()
        {
            do
            {
                input = Input().ToLower();
            } while (ValidateString(input) == false);

            rInput = Draw().ToLower();

            Console.WriteLine("\n{0}\n", Game(input, rInput));
            Console.WriteLine("Your current score is: {0}.", score);
            Console.Write("\nYou want to play again? y/n ");
            string dec = Console.ReadLine();
            Console.WriteLine();
            if (dec == "y") Menu();
            else Console.WriteLine("Thank you for playing. Your overall score is {0}.", score);
        }
    }
}
