using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnotsAndCrosses
{
    class csLogic
    {
        private int[,] iStateArray = new int[3, 3];
        //private Boolean bOnePlayer;
        private Boolean bTwoPlayer = true;

        public Boolean bMultiPlayer
        {
            get { return bTwoPlayer; }
        }


        public void Logic(int iPlayer)
        {
            //Boolean win = CheckRow(0);
        }

        private Boolean CheckColumn(int iPlayer, int y)
        {
            Boolean[] bColumn = new Boolean[3];

            for (int x = 0; x < iStateArray.GetLength(0); x++)
            {
                if (iStateArray[x, y] == iPlayer)
                    bColumn[x] = true;
                else
                    continue;
            } 

            return bColumn.All(i => i);
        }

        private Boolean CheckRow(int iPlayer, int x)
        {
            Boolean[] bRow = new Boolean[3];

            for (int y = 0; y < iStateArray.GetLength(1); y++)
            {
                if (iStateArray[x, y] == iPlayer)
                    bRow[y] = true;
                else
                    continue;
            }

            return bRow.All(i => i);
        }

        public int ReturnState(Point pIndex)
        {
            return iStateArray[pIndex.X, pIndex.Y];
        }

        public void Add(Point pIndex, int iPlayer)
        {
            if(iStateArray[pIndex.X, pIndex.Y] == 0)
                iStateArray[pIndex.X, pIndex.Y] = iPlayer;
        }
    }
}
