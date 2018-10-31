using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class UserPlayer : Player
    {
        public UserPlayer(string name):base(name)
        {
            Console.Write("What is your name?  ");
            name = Validator.ValidateString();
            Name = name;
            ///Choice = generateRoshambo();
        }
        //public static Roshambo newChoice()
        //{
        //    Roshambo newChoice = generateRoshambo();
        //    Player.Choice = generateRoshambo();
        //}
        public override Roshambo generateRoshambo()
        {

            Console.Write("What will you call? (R/P/S) ");
            string x = Validator.ValidateChoice();
            if (x.ToLower() == "r" || x.ToLower() == "rock")
            {
                return Roshambo.Rock;
            }
            else if (x.ToLower() == "p" || x.ToLower() == "paper")
            {
                return Roshambo.Paper;
            }
            else if (x.ToLower() == "s" || x.ToLower() == "scissors")
            {
                return Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("That is not a valid option, we will generate a random choice for you" );
                Random r = new Random();
                int y = r.Next(3);
                if (y == 0)
                {
                    return Roshambo.Rock;
                }
                else if (y == 1)
                {
                    return Roshambo.Paper;
                }
                else
                {
                    return Roshambo.Scissors;
                }
            }
        }
    }
}
