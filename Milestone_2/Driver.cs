using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2_CST_227
{
    class Driver
    {
        static void Main(string[] args)
        {

        /*
         * instantiating the grid class with size 10 by 10
            Grid grid = new Grid(10, 10);
            //reveals the grid to the console for the user to see
            grid.reveal();
         *
         */


            /*
             * creates instance of Minesweeper class
             */
            Minesweeper game = new Minesweeper(10, 10);

            // calls playGame function
            game.playGame();


        }
    }
}
