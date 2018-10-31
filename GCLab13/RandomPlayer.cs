using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name)
        {
            Choice = generateRoshambo();
        }

        public override Roshambo generateRoshambo()
        {
            Random r = new Random();
            int x = r.Next(3);
            if (x == 0)
            {
                return Roshambo.Rock;
            }
            else if (x == 1)
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
