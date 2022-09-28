using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Menu
    {

        public void Main_Menu() 
        {
            int menuOption;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Tic Tac Toe Game");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Intstructions");
                Console.WriteLine("3. Exit");
                Console.Write("Select: ");
                menuOption = int.Parse(Console.ReadLine());
            } while (menuOption > 3 || menuOption < 1);
            if(menuOption == 1) 
            {
                Game startGame = new Game();
                startGame.StartGame();
            }
            else if (menuOption == 2)
            {
                Instruction instruction = new Instruction();
                instruction.Instructions();
            }

        }
    }
}
