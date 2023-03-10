using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class Play
    {
        public void rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("the dice rolled is "+dice);
        }
    }
}
