using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            // A converter argumentos de string em GameItem para ambos os 
            // jogadores
            GameItem player1 = Enum.Parse<GameItem>(args[0]);
            GameItem player2 = Enum.Parse<GameItem>(args[1]);
            
            // Obter resultado do jogo atraves do metodo RockPaperScissors
            GameStatus result = RockPaperScissors(player1, player2);

            // Imprime a mensagem apropriada ao resultado obtido (result)
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }


        // Calcula o resultado do jogo baseado nos itens que os jogadores jogaram
        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            // Guardar o result no GameStatus para ser devolvido
            GameStatus result;

            // Caso seja igual define (result) como empate
            if (player1 == player2)
            {
                result = GameStatus.Draw; //Draw
            }
            // Caso o jogador 1 ganhe defenir (result) como vitoria do jogador 1
            else if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                result = GameStatus.Player1Wins; // Player 1 wins
            }
            // Os unicos casos que sobram são vitórias do jogador 2
            else
            {
                result = GameStatus.Player2Wins; // Player 2 wins
            }

            // Devolver resultado (result)
            return result;
        
        }
    }
}
