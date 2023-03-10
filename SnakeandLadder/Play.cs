using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class Play
    {
        const int LADDER = 1, SNAKE = 2;
        public int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        public void playGame()
        {
            int pos = 0;
            Play p = new Play();
            int dice = p.rollDice();
            Random random = new Random();
            int check = random.Next(0, 3);
            switch (check) 
            {
                case LADDER:
                    pos += dice;
                    break;
                case SNAKE:
                    pos -= dice;
                    break;
            }
            Console.WriteLine("The position after rolling dice is "+pos);
        }
    }
}
