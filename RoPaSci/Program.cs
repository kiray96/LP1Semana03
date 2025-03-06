using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem player1 = Enum.Parse<GameItem>(args[0]);
            GameItem player2 = Enum.Parse<GameItem>(args[1]);

            int result = RockPaperScissors(player1, player2);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(GameItem player1, GameItem player2)
        {
            int  result;

            if (player1 == player2)
            {
                result = 0; // Draw
            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                result = 1; // Player 1 wins
            }
            else
            {
                result = 2; // Player 2 wins
            }

            return result;
        
        }
    }
}
