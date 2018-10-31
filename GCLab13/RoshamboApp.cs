using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class RoshamboApp
    {
        public static void PlayGame()
        {
            UserPlayer player = new UserPlayer("");
            Player computer = ChoosePlayer();
            bool yesNo = true;
            while (yesNo == true)
            {
                Console.WriteLine();
                player.Choice = player.generateRoshambo();
                Console.WriteLine();
                whoWins(player, computer);
                Console.WriteLine();
                yesNo = YesNo("Do you want to play again? (y/n) ");
            }
        }
        public static Player ChoosePlayer()
        {
            Console.Write("Who would you like to play? Random or easy? (R/e) ");
            string x = Validator.ValidateDifficulty();
            if (x.ToLower() == "r" || x.ToLower() == "random")
            {
                RandomPlayer random = new RandomPlayer("Random Dan");
                Console.WriteLine("You are going to play Random Dan!");
                return random;
            }
            else
            {
                RockPlayer rock = new RockPlayer("Mr. Geology");
                Console.WriteLine("You are going to play Mr. Geology! (hint... he likes rocks");

                return rock;
            }
            
        }
        public static bool YesNo(string message)
        {
            Console.Write(message);
            string entry = Console.ReadLine();
            while (entry.ToLower() != "n" || entry.ToLower() != "y" || entry.ToLower() != "no" || entry.ToLower() != "yes")
            {
                if (entry.ToLower() == "n" || entry.ToLower() == "no")
                {
                    return false;
                }
                else if (entry.ToLower() == "y" || entry.ToLower() == "yes")
                {
                    return true;
                }
                else
                {
                    Console.Write($"That is not a valid answer, {message}");
                    entry = Console.ReadLine();
                    continue;
                }
            }
            Console.WriteLine("This should not be seen.");
            return false;
        }
        public static void whoWins(Player player, Player computer)
        {
            computer.Choice = computer.generateRoshambo();
            if (player.Choice == computer.Choice)
            {
                Console.WriteLine($"{computer.Name}: {computer.Choice}");
                Console.WriteLine($"{player.Name}: {player.Choice}");
                Console.WriteLine("Draw!");
            }
            else if ((player.Choice == Roshambo.Rock && computer.Choice == Roshambo.Scissors) || (player.Choice == Roshambo.Paper && computer.Choice == Roshambo.Rock) || (player.Choice == Roshambo.Scissors && computer.Choice == Roshambo.Paper))
            {
                Console.WriteLine($"{computer.Name}: {computer.Choice}");
                Console.WriteLine($"{player.Name}: {player.Choice}");

                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine($"{computer.Name}: {computer.Choice}");
                Console.WriteLine($"{player.Name}: {player.Choice}");

                Console.WriteLine("You lose...");
            }
        }
    }
}
