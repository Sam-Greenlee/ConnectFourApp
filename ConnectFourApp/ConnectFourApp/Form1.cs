/*
 * Author: Samuel Greenlee
 * Project: Assignment Five
 * Date  : April 13, 2020
 * Desc  : This code creates a game of connect 4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourApp
{
    public partial class frmConnectFourApp : Form
    {
        public frmConnectFourApp()
        {
            InitializeComponent();
        }
        //Create a broad scop array for the holes in the board
        TextBox[,] gameCells = new TextBox[6,7];

        //Create the drop buttons
        Button[] dropButtons = new Button[7];

        //Create a broad scop variable for the player's color
        string player = "Red";

        private void frmConnectFourApp_Load(object sender, EventArgs e)
        {
            //Create colum and game hole default location
            int left = 10;
            int top = 10;

            for (int b = 0; b <= dropButtons.GetUpperBound(0); b++)
            {
                // make the button
                Button aButton = new Button();
                aButton.Size = new System.Drawing.Size(50, 50);
                aButton.Location = new Point(left,top);
                aButton.Text = "Push";
                aButton.Tag = b;
                dropButtons[b] = aButton;
                aButton.Click += AButton_Click;
                pnlBoard.Controls.Add(aButton);

                left += 100;
            }

            left = 10;
            top = 50 + 10;

            for (int r = 0; r <= gameCells.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= gameCells.GetUpperBound(1); c++)
                {
                    // make all of the text boxes
                    TextBox t = new TextBox();
                    t.Multiline = true;
                    t.Size = new Size(50, 50);
                    t.Location = new Point(left, top);
                    pnlBoard.Controls.Add(t);
                    gameCells[r, c] = t;
                    left += 100;
                }
                left = 10;

                top += 50;
            }
        }

        //Click button event
        private void AButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int col = Convert.ToInt16(clickedButton.Tag);

            int dropSpot = gameCells.GetUpperBound(0);

            NextPlayer(col, ref dropSpot, gameCells);

            if (player == "Red")
            {
                gameCells[dropSpot, col].BackColor = Color.Red;
                gameCells[dropSpot, col].Tag = "Red";
                player = "Blue";
            }
            else
            {
                gameCells[dropSpot, col].BackColor = Color.Blue;
                gameCells[dropSpot, col].Tag = "Blue";
                player = "Red";
            }

            //Check for win
            CheckForWin();
        }

        //This method iterates through each player giving them a chance to play
        private void NextPlayer(int col, ref int dropSpot, TextBox[,] gameCells)
        {
            for (int i = gameCells.GetUpperBound(0); i >= 0; i--)
            {
                if (gameCells[i, col].Tag != null)
                {
                    if (dropSpot < 1)
                    {
                        MessageBox.Show("This colum is full. Pick another one please!");
                    }
                    else
                    {
                        dropSpot = i - 1;
                    }
                }
            }
        }

        //This is the method that checks for the win
        private void CheckForWin()
        {
            // Check Row for win
            CheckRowWin();

            // Check Col for win
            CheckColWin();
        }

        //This is the method that checks the rows for a win
        private void CheckRowWin()
        {
            int winCount = 0;
            for (int row = 0; row <= gameCells.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= gameCells.GetUpperBound(1); col++)
                {
                    if (gameCells[row, col].Tag?.ToString() == player)
                    {
                        winCount++;
                    }
                }
                
                if (winCount == 4)
                {
                    //Display what player wins in the textbox
                    TextBoxDisplay();
                }

                winCount = 0;
            }

        }

        //This is the method that checks the column for a win
        private void CheckColWin()
        {
            int winCount = 0;
            for (int col = 0; col <= gameCells.GetUpperBound(1); col++)
            {
                for (int row = 0; row <= gameCells.GetUpperBound(0); row++)
                {
                    if (gameCells[row, col].Tag?.ToString() == player)
                    {
                        winCount++;
                    }
                }

                if (winCount == 4)
                {
                    //Display what player wins in the textbox
                    TextBoxDisplay();
                }

                winCount = 0;
            }
        }

        //This method displays what player wins in the textbox
        private void TextBoxDisplay()
        {
            txtWinnerBox.Text = "Player " + player.ToString() + " Wins!";
        }


    }
}
