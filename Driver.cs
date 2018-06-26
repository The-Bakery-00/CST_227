using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_CST227
{
    class Driver
    {
        static void Main (string[] args)
        {

            // instantiating the grid class
            Grid grid = new Grid(10, 10);

            // reveals the grid to the console
            grid.reveal();
        }
    }
}
