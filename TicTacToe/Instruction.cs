using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Instruction
    {

        public void Instructions() 
        {
            int instructioOption;
            do
            {
                Console.Clear();
                Console.WriteLine("|------------------Instructions------------------------");
                Console.WriteLine("|A. Player 1 is X.                                    |");
                Console.WriteLine("|B. Player 2 is O.                                    |");
                Console.WriteLine("|C. Player {x} Select from 1 to 9 to place your move. |");
                Console.WriteLine("|D. Player {o} Select from 1 to 9 to place your move. |");
                Console.WriteLine("|E. Game Board.                                       |");
                Console.WriteLine("|    1   |   2   |   3                                |");
                Console.WriteLine("|    ----+-------+----                                |");
                Console.WriteLine("|    4   |   5   |   6                                |");
                Console.WriteLine("|    ----+-------+----                                |");
                Console.WriteLine("|    7   |   8   |   9                                |");
                Console.WriteLine("|-----------------------------------------------------|");
                Console.WriteLine("1.Back");
                Console.Write("Select: ");
                instructioOption = int.Parse(Console.ReadLine());
            } while (instructioOption != 1);

            Menu mainMenu = new Menu();
            mainMenu.Main_Menu();

        }

        

    }
}
