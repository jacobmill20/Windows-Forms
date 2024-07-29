using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class MineBoard
    {
        enum Cover
        {
            Hide, // 0
            Show, // 1
            Mark  // 2
        }
        private int[,] board;
        private byte[,] cover;
        private int nRows, nCols, nMines;
        public int NumMines { get { return nMines; } }
        public MineBoard(int r, int c)
        {
            nRows = r;
            nCols = c;
            board = new int[nRows, nCols];
            cover = new byte[nRows, nCols];
            nMines = (int)(r * c * 0.1);
            setMines();
            updateMineCounts();
        }
        private void setMines()
        {
            ///////////////////////////////////
            // NEED MORE WORK HERE
            ///////////////////////////////////
            // Select positions randomly no more than 10%.
            // For example,
            // 9x9 board has 81 positions in total. Select 8 distinct positions.
            // 9x12 board has 108 positions in total. Select 10 distinct positions.
            int mines = (int)(nRows * nCols * 0.1);
            Random rand = new Random();
            int r, c;
            while (mines > 0)
            {
                r = rand.Next(0, nRows);
                c = rand.Next(0, nCols);
                if(board[r, c] != 9)
                {
                    board[r, c] = 9;
                    mines--;
                }
            }
        }
        public int open(int r, int c) { 
            // open the position by a regular click
            // return the value at the position
            cover[r, c] = (byte)Cover.Show;
            if(board[r, c] == 0) // if no mine around 
                uncoverAllConnectedZeros(r, c); //open all connected 'no-mine-around' positions
            return board[r, c];
        }
        public void mark(int r, int c) {
            // toggle operation on cover. Mark <-> Hide
            // The number of remaining mines is updated.
            if (cover[r, c] == (byte)Cover.Hide)
            {
                cover[r, c] = (byte)Cover.Mark;
                nMines--;
            }
            else if (cover[r, c] == (byte)Cover.Mark)
            {
                cover[r, c] = (byte)Cover.Hide;
                nMines++;
            }
        }
        public String get(int r, int c) {
            if (cover[r, c] == (byte)Cover.Hide) // covered
                return " "; // space
            else if (cover[r, c] == (byte)Cover.Show) // opened(uncovered)
                return "" + board[r, c];
            else // marked
                return "@";
        }
        public int getValue(int r, int c) { return board[r, c]; }
        
        private bool isValidPosition(int r, int c)
        {
            return 0 <= r && r < board.GetLength(0) && 0 <= c && c < board.GetLength(1);
        }
        private int[] getNeighborPositions(int idx)
        {
            // return the indexes of the neighbors given an index
            return getNeighborPositions(idx / board.GetLength(1), idx % board.GetLength(1));
        }
        private int[] getNeighborPositions(int r, int c)
        {
            // return the indexes of the neighbors given a position (r,c)
            List<int> nPos = new List<int>();
            for (int x = r - 1; x <= r + 1; x++)
                for (int y = c - 1; y <= c + 1; y++)
                    if (isValidPosition(x, y) && !(x == r && y == c))
                        nPos.Add(x * board.GetLength(1) + y); ;
            return nPos.ToArray();
        }
        private int[] getNeighborValues(int r, int c)
        {
            // return the number of mines around the position (r,c)
            int[] nPos = getNeighborPositions(r, c);
            for (int i = 0; i < nPos.Length; i++)
            {
                (r, c) = (nPos[i] / board.GetLength(1), nPos[i] % board.GetLength(1));
                nPos[i] = board[r, c];
            }
            return nPos;
        }
        private void updateMineCounts()
        {
            // Update each position by the number of mines around it.
            // If you have two mines (value 9) around you, update board at the position as 2.
            for (int r = 0; r < board.GetLength(0); r++)
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if (board[r, c] != 9)
                        board[r, c] = getNeighborValues(r, c).Aggregate(0, (total, next) => total + next / 9);

                }
        }
        private void uncoverAllConnectedZeros(int r, int c)
        {
            var checkedIdx = new HashSet<int>();
            var checkList = new Queue<int>();

            int idx = r * board.GetLength(1) + c;
            checkList.Enqueue(idx);
            while (checkList.Count > 0)
            {
                idx = checkList.Dequeue();
                checkedIdx.Add(idx);
                foreach (var nei in getNeighborPositions(idx))
                {
                    (r, c) = (nei / board.GetLength(1), nei % board.GetLength(1));
                    cover[r, c] = (byte)Cover.Show;
                    if (board[r, c] == 0 && !checkedIdx.Contains(nei) && !checkList.Contains(nei))
                        checkList.Enqueue(nei);
                }
            }
        }
    }
}
