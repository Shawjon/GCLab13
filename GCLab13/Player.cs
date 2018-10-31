using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    public abstract class Player
    {
        public Roshambo Choice { get; set; }

        public string Name;
        ///ublic string name { get; set; }

        public abstract  Roshambo generateRoshambo();
        public Player(string name)
        {
            //Choice = choice;
            Name = name;

        }
       //public string name { get; set; }
    }

}
