using ChessBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGUIProject
{
    public partial class Form1 : Form
    {
        ///Creare Tabla
        static Board myBoard = new Board();
        ///Celula cu care lucram pe tabla
       
        ///Array de butoane pe tabla
        public Button[,] btnTable = new Button[myBoard.Size, myBoard.Size];
        public Form1()
        {
            InitializeComponent();
            populateTable();
            MoveOnTable();
        }

        private void populateTable()
        {
            ///Dimensiunile butonului
            int buttonSize = panel1.Width / myBoard.Size;
            panel1.Height = panel1.Width;

            ///popularea tablei cu butoane care reprezinta patratelele de pe tabla de sah
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnTable[i, j] = new Button();
                    btnTable[i, j].Height = buttonSize;
                    btnTable[i, j].Width = buttonSize;

                    btnTable[i, j].Enabled = false;

                    panel1.Controls.Add(btnTable[i, j]);
                    btnTable[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                }
            }
        }
        public void MoveOnTable()
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    if (myBoard.TheTable[i, j].CurrentlyOccupied == true)
                        btnTable[myBoard.TheTable[i, j].RowNumber, myBoard.TheTable[i, j].ColumnNumber].BackColor = Color.Red;
                    if (myBoard.TheTable[i, j].CurrentlyOccupied == false)
                        btnTable[myBoard.TheTable[i, j].RowNumber, myBoard.TheTable[i, j].ColumnNumber].BackColor = default(Color);
                }
            }
            if (myBoard.msg == true)
                MessageBox.Show("Ai terminat");
        }
        private void upButton_Click(object sender, EventArgs e)
        {
            myBoard.Move("UP");
            MoveOnTable();
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            myBoard.Move("RIGHT");
            MoveOnTable();
        }
        private void leftButton_Click(object sender, EventArgs e)
        {
            myBoard.Move("LEFT");
            MoveOnTable();
        }
        private void downButton_Click(object sender, EventArgs e)
        {
            myBoard.Move("DOWN");
            MoveOnTable();
        }
        private void repeatButton_Click(object sender, EventArgs e)
        {
            myBoard.Move("REPEAT");
            MoveOnTable();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            myBoard.Move("CANCEL");
            MoveOnTable();
        }
    }
}
