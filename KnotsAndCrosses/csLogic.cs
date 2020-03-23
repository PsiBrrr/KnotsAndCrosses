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
        private static int iSize = 3;
        private static int[,] iStateArray = new int[iSize, iSize];
        private static Boolean[] bAll = new Boolean[(iSize * iSize)];
        private static Boolean[] bColumn = new Boolean[iSize];
        private static Boolean[] bRow = new Boolean[iSize];
        private static Boolean[] bDiagonal = new Boolean[iSize];
        private static Boolean bTwoPlayer = true;
        
        public static Boolean bMultiPlayer
        {
            get { return bTwoPlayer; }
            set { bTwoPlayer = value; }
        }

        public static int iCurrentPlayer { get; private set; } = 1;

        public Boolean PlayerLogic()
        {
            if (CheckColumn(iCurrentPlayer) || CheckRow(iCurrentPlayer) || CheckDiagonalDownRight(iCurrentPlayer) || CheckDiagonalDownLeft(iCurrentPlayer))
                return true;
            else
                return false;
        }

        public Boolean TieLogic()
        {
            if (CheckAll())
                return true;
            else
                return false;
        }

        private Boolean CheckColumn(int iPlayer)
        {
            for (int y = 0; y < iSize; y++)
            {
                for (int x = 0; x < iSize; x++)
                {
                    if (iStateArray[y, x] == iPlayer)
                        bColumn[x] = true;
                    else
                        continue;
                }
                if (!bColumn.All(k => k))
                    Array.Clear(bColumn, 0, iSize);
            }
            return bColumn.All(k => k); /*using k to prevent variable overlap*/
        }

        private Boolean CheckRow(int iPlayer)
        {
            for (int x = 0; x < iSize; x++)
            {
                for (int y = 0; y < iSize; y++)
                {
                    if (iStateArray[y, x] == iPlayer)
                        bRow[y] = true;
                    else
                        continue;
                }
                if(!bRow.All(k => k))
                    Array.Clear(bRow, 0, iSize);
            }

            return bRow.All(k => k); /*using k to prevent variable overlap*/
        }

        private Boolean CheckDiagonalDownRight(int iPlayer) 
        {
            for (int i = 0; i < iSize; i++)
            {
                if (iStateArray[i, i] == iPlayer)
                    bDiagonal[i] = true;
                else
                    continue;
            }

            if (!bDiagonal.All(k => k)) /*using k to prevent variable overlap*/
            {
                Array.Clear(bDiagonal, 0, iSize);
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean CheckDiagonalDownLeft(int iPlayer)
        {
            int i = iSize - 1;
            for (int j = 0; j < iSize; j++)
            {
                if (iStateArray[j, i] == iPlayer)
                    bDiagonal[j] = true;
                else
                    continue;

                i--;
            }

            if (!bDiagonal.All(k => k)) /*using k to prevent variable overlap*/
            {
                Array.Clear(bDiagonal, 0, iSize);
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean CheckAll() //Check if all items have been selected
        {
            int i = 0;
            for (int x = 0; x < iSize; x++)
            {
                for (int y = 0; y < iSize; y++)
                {
                    if (iStateArray[y, x] != 0)
                    {
                        bAll[i] = true;
                        i++;
                    }
                    else
                        continue;
                }
            }

            return bAll.All(k => k);
        }

        public static int ReturnState(Point pIndex)
        {
            return iStateArray[pIndex.X, pIndex.Y];
        }

        public static int UpdatePlayer()
        {
            if (iCurrentPlayer == 1)
                iCurrentPlayer = 2;
            else
                iCurrentPlayer = 1;

            return iCurrentPlayer;
        }

        public static void Add(Point pIndex)
        {
            if(iStateArray[pIndex.X, pIndex.Y] == 0)
                iStateArray[pIndex.X, pIndex.Y] = iCurrentPlayer;
        }

        public static void Reset()
        {
            Array.Clear(iStateArray, 0, (iSize * iSize));
            Array.Clear(bColumn, 0, iSize);
            Array.Clear(bRow, 0, iSize);
            Array.Clear(bDiagonal, 0, iSize);
            Array.Clear(bAll, 0, (iSize * iSize));
        }
    }
}
