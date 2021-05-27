using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osAndXs
{
    class Board
    {
        private int[,] board = new int[3,3];

        public bool addCounter(int x,int y, int counter)
        {
            bool added = false;
            if(x < 0 || x > 3 || y < 0 || y > 3) return false;
            if (counter != 1 && counter != 2) return false;

            
            if (board[x,y] == 0)
            {
                board[x,y] = counter;
                added = true;
            }

            return added;
        }

        public int[,] getBoard()
        {
            return board;
        }
    }
}
