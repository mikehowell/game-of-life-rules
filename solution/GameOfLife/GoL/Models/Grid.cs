using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL.Models
{
    public class Grid
    {
        private Cell[,] _grid = new Cell[3,3];

        public Grid()
        {
            for (int i = 0; i < _grid.Length; i++)
            {
                for (int j = 0; j < _grid.Length; j++)
                {
                    _grid[i,j] = new Cell();
                }
            }
        }
    }
}
