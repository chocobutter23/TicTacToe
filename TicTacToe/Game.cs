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
            int[] gameMarker = {1,2,3,4,5,6,7,8,9};
            
            do
            {
                Console.Clear();
                currentPlayer = GetNextPlayer(currentPlayer);
                DrawGameBoard(gameMarker);
                HeadsUpDisplay(currentPlayer);
                GameEngine(gameMarker,currentPlayer);
                int userInput;
                userInput = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (true);
           
           
        }

        private void GameEngine(int[] gameMarker, int currentPlayer)
        {
            int userInput = int.Parse(Console.ReadLine());
            if(userInput == 1)
            { 
                Console.Clear();
                int currentMarker = gameMarker[userInput - 1];
            }
        }

        static void HeadsUpDisplay(int PlayerNumber)
        {
            Console.WriteLine("Game Start");
            Console.Write($"Player {PlayerNumber}: ");

        }

        static void DrawGameBoard(int[] gameMarker) 
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
