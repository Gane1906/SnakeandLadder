﻿using System;
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
            int dice = 0; 
            Random random = new Random();
            while (pos < 100)
            {
                int check = random.Next(0, 3);
                dice = p.rollDice(); 
                switch (check)
                {
                    case LADDER:
                        pos += dice;
                        break;
                    case SNAKE:
                        pos -= dice;
                        if (pos < 0)
                            pos = 0;
                        break;
                }
            }
            Console.WriteLine("The position is " + pos);
        }
    }
}
