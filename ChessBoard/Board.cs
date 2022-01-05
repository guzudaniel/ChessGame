using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class Board
    {
        ///Declarare dimensiune
        public int Size = 8;
        ///Declarare tabla
        public Cell[,] TheTable { get; set; }
        ///Celula initiala
        public int currentRow = 4;
        public int currentColumn = 7;
        const int ROW = 4;
        const int COL = 7;

        public bool msg = false;

        ///List of moves
        List<Cell> Moves = new List<Cell>();

        public Board()
        {
            ///Initializare Tabla
            TheTable = new Cell[Size, Size];

            ///Atribuire valori la Tabla
            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    TheTable[i, j] = new Cell(i, j);
                }
            }
            TheTable[currentRow,currentColumn].CurrentlyOccupied = true;
        }
        public void Move(string s)
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    TheTable[i, j].CurrentlyOccupied = false;
            switch (s)
            {
                case "UP":
                    if (IsSafe(currentRow, currentColumn - 1))
                    {
                        TheTable[currentRow, currentColumn - 1].CurrentlyOccupied = true;
                        Moves.Add(TheTable[currentRow, currentColumn - 1]);
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = false;
                        currentColumn = currentColumn - 1;
                    }
                    else
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = true;
                    break;
                case "DOWN":
                    if (IsSafe(currentRow, currentColumn + 1))
                    {
                        TheTable[currentRow, currentColumn + 1].CurrentlyOccupied = true;
                        Moves.Add(TheTable[currentRow, currentColumn + 1]);
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = false;
                        currentColumn = currentColumn + 1;
                    }
                    else
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = true;
                    break;
                case "LEFT":
                    if (IsSafe(currentRow - 1, currentColumn))
                    {
                        TheTable[currentRow - 1, currentColumn].CurrentlyOccupied = true;
                        Moves.Add(TheTable[currentRow-1, currentColumn]);
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = false;
                        currentRow = currentRow - 1;
                    }
                    else
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = true;
                    break;
                case "RIGHT":
                    if (IsSafe(currentRow + 1, currentColumn))
                    {
                        TheTable[currentRow + 1, currentColumn].CurrentlyOccupied = true;
                        Moves.Add(TheTable[currentRow+1, currentColumn]);
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = false;
                        currentRow = currentRow + 1;
                    }
                    else
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = true;
                    break;
                case "REPEAT":
                    {
                        if (Moves.Count > 1)
                        {
                            int rowTemp = Moves[Moves.Count - 1].RowNumber;
                            int colTemp = Moves[Moves.Count - 1].ColumnNumber;


                            TheTable[rowTemp, colTemp].CurrentlyOccupied = false;

                            Moves.RemoveAt(Moves.Count - 1);

                            rowTemp = Moves[Moves.Count - 1].RowNumber;
                            colTemp = Moves[Moves.Count - 1].ColumnNumber;
                            currentRow = rowTemp;
                            currentColumn = colTemp;
                            TheTable[rowTemp, colTemp].CurrentlyOccupied = true;
                        }
                        else
                        {
                            TheTable[Moves[0].RowNumber, Moves[0].ColumnNumber].CurrentlyOccupied = false;
                            TheTable[ROW, COL].CurrentlyOccupied = true;
                        }
                    }
                    break;
                case "CANCEL":
                    {
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = false;
                        Moves.Clear();
                        currentRow = ROW;
                        currentColumn = COL;
                        TheTable[currentRow, currentColumn].CurrentlyOccupied = true;
                    }
                    break;
            }
            if (currentColumn == 0) msg = true;
            else msg = false;

        }
        public bool IsSafe(int x, int y)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
