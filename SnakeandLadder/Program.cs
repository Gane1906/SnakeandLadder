using System;
namespace SnakeandLadder
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to snake and ladder game");
            Play play = new Play();
            play.rollDice();
        }
    }
}