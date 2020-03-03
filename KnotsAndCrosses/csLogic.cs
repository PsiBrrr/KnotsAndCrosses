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


        public Boolean Logic(int iPlayer)
        {
            if (CheckColumn(iPlayer) || CheckRow(iPlayer) || CheckDiagonalDownRight(iPlayer) || CheckDiagonalDownLeft(iPlayer))
                return true;
            else
                return false;
        }

        private Boolean CheckColumn(int iPlayer)
        {
            Boolean[] bColumn = new Boolean[3];

            for (int y = 0; y < iStateArray.GetLength(0); y++)
            {
                for (int x = 0; x < iStateArray.GetLength(1); x++)
                {
                    if (iStateArray[y, x] == iPlayer)
                        bColumn[x] = true;
                    else
                        continue;
                }
                if (!bColumn.All(i => i))
                    Array.Clear(bColumn, 0, iStateArray.GetLength(1));
            }
            return bColumn.All(i => i);
        }

        private Boolean CheckRow(int iPlayer)
        {
            Boolean[] bRow = new Boolean[3];

            for (int x = 0; x < iStateArray.GetLength(1); x++)
            {
                for (int y = 0; y < iStateArray.GetLength(0); y++)
                {
                    if (iStateArray[y, x] == iPlayer)
                        bRow[y] = true;
                    else
                        continue;
                }
                if(!bRow.All(i => i))
                    Array.Clear(bRow, 0, iStateArray.GetLength(0));
            }

            return bRow.All(i => i);
        }

        private Boolean CheckDiagonalDownRight(int iPlayer) 
        {
            Boolean[] bDiagonal = new Boolean[3];

            for(int i = 0; i < 3; i++)
            {
                if (iStateArray[i, i] == iPlayer)
                    bDiagonal[i] = true;
                else
                    continue;
            }

            return bDiagonal.All(i => i);
        }

        private Boolean CheckDiagonalDownLeft(int iPlayer)
        {
            Boolean[] bDiagonal = new Boolean[3];

            for (int y = 0; y < iStateArray.GetLength(1); y++)
            {
                for (int x = iStateArray.GetLength(0) - 1; x > -1; x--)
                {
                    if (iStateArray[y, x] == iPlayer)
                        bDiagonal[y] = true;
                    else
                        continue;
                }
            }

            return bDiagonal.All(i => i);
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
