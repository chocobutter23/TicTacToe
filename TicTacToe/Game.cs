using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public void StartGame() 
        {

            int currentPlayer = -1;
            char[] gameMarker = {'1', '2', '3', '4', '5', '6', '7', '8', '9' };
            
            do
            {
           
                currentPlayer = GetNextPlayer(currentPlayer);
                DrawGameBoard(gameMarker);
                HeadsUpDisplay(currentPlayer);
                GameEngine(gameMarker,currentPlayer);
            } while (true);
           
           
        }

        private void GameEngine(char[] gameMarker, int currentPlayer)
        {
            string userInput = Console.ReadLine();
            if (userInput.Equals("1") || userInput.Equals("2") || userInput.Equals("3") || userInput.Equals("4") || userInput.Equals("5") || userInput.Equals("6") || userInput.Equals("7") || userInput.Equals("8") || userInput.Equals("9"))
            {
                Console.Clear();
                int.TryParse(userInput, out var gamePlacementMaker);
                char currentMarker = gameMarker[gamePlacementMaker - 1];
                if (currentMarker.Equals("X") || currentMarker.Equals("O"))
                {
                    Console.WriteLine("Placement has already have a marker. Please select another placement");
                }
                else 
                {
                    gameMarker[gamePlacementMaker - 1] = GetPlayerMarker(currentPlayer);
                }
            }
        }

        public static char GetPlayerMarker(int player) 
        {
            if (player % 2 == 0) 
            {
                return '0';
            }
            return 'X';
        }

        static void HeadsUpDisplay(int PlayerNumber)
        {
            Console.WriteLine("Game Start");
            Console.Write($"Player {PlayerNumber}: ");

        }

        static void DrawGameBoard(char[] gameMarker) 
        {
            Console.WriteLine(" -------------------- ");
            Console.WriteLine($"| {gameMarker[0]}   |   {gameMarker[1]}   |   {gameMarker[2]}  |");
            Console.WriteLine("| ----+-------+------|");
            Console.WriteLine($"| {gameMarker[3]}   |   {gameMarker[4]}   |   {gameMarker[5]}  |");
            Console.WriteLine("| ----+-------+------|");
            Console.WriteLine($"| {gameMarker[6]}   |   {gameMarker[7]}  |   {gameMarker[8]}   |");
            Console.WriteLine(" -------------------- ");

        }
        static int GetNextPlayer(int player) 
        {
            int nowPlayer;
            if (player.Equals(1)) 
            {
                nowPlayer = 2;
            }
            else 
            {
                nowPlayer = 1;
            }
            return nowPlayer;
        }
    }
}
