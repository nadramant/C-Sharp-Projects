using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryGame
{
    public class Board
    {
        private Cell[,] m_GameBoard;

        public Board(int i_BoardLength, int i_BoardWidth)
        {
            m_GameBoard = new Cell[i_BoardLength, i_BoardWidth];

            for(int i = 0; i < i_BoardLength; i++)
            {
                for(int j = 0; j < i_BoardWidth; j++)
                {
                    m_GameBoard[i, j] = new Cell();
                }
            }
        }

        public Cell this[int index1, int index2]
        {
            get
            {
                return m_GameBoard[index1, index2];
            }
            set
            {
                m_GameBoard[index1, index2] = value;
            }
        }

        public void InitialBoard()
        {
            int i = 1;

            foreach(Cell item in m_GameBoard)
            {
                item.PairNum = i;
                i++;
            }

            swapRandomPlaces();
        }

        private void swapRandomPlaces()
        {
            Random randCol = new Random();
            Random randRow = new Random();
            int currCol, currRow;

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    currCol = randCol.Next(Cols);
                    currRow = randRow.Next(Rows);
                    Cell temp = m_GameBoard[i, j];
                    m_GameBoard[i, j] = m_GameBoard[currRow, currCol];
                    m_GameBoard[currRow, currCol] = temp;
                }
            }
        }

        private void findNextUnrevealedCell(out int o_RowNum, out int o_ColNum) // change to findNextUnrevealedCell
        {
            o_RowNum = o_ColNum = 0;

            for(int i = 0; i < m_GameBoard.GetLength(0); i++)
            {
                for(int j = 0; j < m_GameBoard.GetLength(1); j++)
                {
                    if(m_GameBoard[i, j].IsCellSetted == false)
                    {
                        o_RowNum = i;
                        o_ColNum = j;
                        break;
                    }
                }
            }
        }

        public Cell[,] GameBoard
        {
            get
            {
                return m_GameBoard;
            }
            set
            {
                m_GameBoard = value;
            }
        }

        public int Rows
        {
            get
            {
                return GameBoard.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return GameBoard.GetLength(1);
            }
        }

        public bool IsInsideBorders(char i_rowInput, char i_colInput, out int o_PickedRowIndex, out int o_PickedColIndex)
        {
            bool insideBorders = false;
            o_PickedRowIndex = -1;
            o_PickedColIndex = -1;

            int.TryParse(i_rowInput.ToString(), out o_PickedRowIndex);
            o_PickedRowIndex = o_PickedRowIndex - 1;

            int.TryParse((i_colInput - 'A').ToString(), out o_PickedColIndex);

            if((0 <= o_PickedColIndex && o_PickedColIndex < this.Cols) && (0 <= o_PickedRowIndex && o_PickedRowIndex < this.Rows))
            {
                insideBorders = true;
            }

            return insideBorders;
        }
    }
}
