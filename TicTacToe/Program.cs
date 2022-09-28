using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Menu mainMenu = new Menu();
            mainMenu.Main_Menu();

            //Section 1
            //1.Provide Instruction
            
            //1.1Menu
            //1.2Display Player Sign. Player 1 is X and Player 2 is O
            //1.3Who's Turn it is?



            //Section 2
            //2.Draw the game board
            //2.1Game will have 3 rows and 3 coulmns and will be number from 1 to 9


            //Section 3
            //3. As the user places markers on the game update the board then notify which player
            //3.1. After each turn judge if there is a winner
            //3.2. If no winner keep playing by going to step 1
            //3.3 If all markers are placed and no winner then its a draw. Stop the game
            //3.4 If we have a winner , announce who won and stop the game/


            Console.ReadKey();

        }
    }
}
