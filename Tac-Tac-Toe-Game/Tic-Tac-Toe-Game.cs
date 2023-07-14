using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tac_Tac_Toe_Game
{
    public partial class Tic_Tac_Toe_Game : Form
    {
        string player1Name;
        string player2Name;
        char winner;
        int playerX_Score = 0;
        int playerO_Score = 0;
        int checkCounter = 0;
        int buttonCounter = 0; //from 0 to 9 if we reach 9, that means (draw) no winner
        bool turn = true; //true => player x turn /// false => player o turn
        bool thereIsWinner = false;
        private char HorizontalCheck()
        {
            char winner = '.';
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                thereIsWinner = true;
                if (A1.Text == "X")
                {
                    winner = 'X';
                    A1.BackColor = Color.RoyalBlue;
                    A2.BackColor = Color.RoyalBlue;
                    A3.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    A1.BackColor = Color.Brown;
                    A2.BackColor = Color.Brown;
                    A3.BackColor = Color.Brown;
                }
            }
            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                thereIsWinner = true;
                if (B1.Text == "X")
                {
                    winner = 'X';
                    B1.BackColor = Color.RoyalBlue;
                    B2.BackColor = Color.RoyalBlue;
                    B3.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    B1.BackColor = Color.Brown;
                    B2.BackColor = Color.Brown;
                    B3.BackColor = Color.Brown;
                }
            }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                thereIsWinner = true;
                if (C1.Text == "X")
                {
                    winner = 'X';
                    C1.BackColor = Color.RoyalBlue;
                    C2.BackColor = Color.RoyalBlue;
                    C3.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    C1.BackColor = Color.Brown;
                    C2.BackColor = Color.Brown;
                    C3.BackColor = Color.Brown;
                }
            }
            return winner;
        }
        private char VerticalCheck()
        {
            char winner = '.';
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
            {
                thereIsWinner = true;
                if (A1.Text == "X")
                {
                    winner = 'X';
                    A1.BackColor = Color.RoyalBlue;
                    B1.BackColor = Color.RoyalBlue;
                    C1.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    A1.BackColor = Color.Brown;
                    B1.BackColor = Color.Brown;
                    C1.BackColor = Color.Brown;
                }
            }
            if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
            {
                thereIsWinner = true;
                if (A2.Text == "X")
                {
                    winner = 'X';
                    A2.BackColor = Color.RoyalBlue;
                    B2.BackColor = Color.RoyalBlue;
                    C2.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    A2.BackColor = Color.Brown;
                    B2.BackColor = Color.Brown;
                    C2.BackColor = Color.Brown;
                }
            }
            if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
            {
                thereIsWinner = true;
                if (A3.Text == "X")
                {
                    winner = 'X';
                    A3.BackColor = Color.RoyalBlue;
                    B3.BackColor = Color.RoyalBlue;
                    C3.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    A3.BackColor = Color.Brown;
                    B3.BackColor = Color.Brown;
                    C3.BackColor = Color.Brown;
                }
            }
            return winner;
        }
        private char DiagonalCheck()
        {
            char winner = '.';
            if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                thereIsWinner = true;
                if (A1.Text == "X")
                {
                    winner = 'X';
                    A1.BackColor = Color.RoyalBlue;
                    B2.BackColor = Color.RoyalBlue;
                    C3.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    A1.BackColor = Color.Brown;
                    B2.BackColor = Color.Brown;
                    C3.BackColor = Color.Brown;
                }
            }
            if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
            {
                thereIsWinner = true;
                if (A3.Text == "X")
                {
                    winner = 'X';
                    A3.BackColor = Color.RoyalBlue;
                    B2.BackColor = Color.RoyalBlue;
                    C1.BackColor = Color.RoyalBlue;
                }
                else
                {
                    winner = 'O';
                    A3.BackColor = Color.Brown;
                    B2.BackColor = Color.Brown;
                    C1.BackColor = Color.Brown;
                }
            }
            return winner;
        }
        public Tic_Tac_Toe_Game(string player1Name_, string player2Name_)
        {
            if (player1Name_ == "")
            {
                player1Name_ = "Player X";
            }
            if (player2Name_ == "")
            {
                player2Name_ = "Player O";
            }
            player1Name = player1Name_;
            player2Name = player2Name_;
            InitializeComponent();
        }
        private void Tic_Tac_Toe_Game_Load(object sender, EventArgs e)
        {
            Player1.Text = player1Name + " :";
            Player2.Text = player2Name + " :";
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            buttonCounter++;
            if (buttonCounter < 9)
            {
                checkCounter = 0;
                Button button = (Button)sender;
                if (turn)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
                turn = !turn;
                button.Enabled = false;
                while (checkCounter < 3 && !thereIsWinner)
                {
                    switch (checkCounter)
                    {
                        case 0:
                            winner = HorizontalCheck();
                            if (winner != '.')
                            {
                                if (winner == 'X')
                                {
                                    playerX_Score++;
                                    Player1_Score.Text = playerX_Score.ToString();
                                }
                                else
                                {
                                    playerO_Score++;
                                    Player2_Score.Text = playerO_Score.ToString();
                                }
                            }
                            break;
                        case 1:
                            winner = VerticalCheck();
                            if (winner != '.')
                            {
                                if (winner == 'X')
                                {
                                    playerX_Score++;
                                    Player1_Score.Text = playerX_Score.ToString();
                                }
                                else
                                {
                                    playerO_Score++;
                                    Player2_Score.Text = playerO_Score.ToString();
                                }
                            }
                            break;
                        case 2:
                            winner = DiagonalCheck();
                            if (winner != '.')
                            {
                                if (winner == 'X')
                                {
                                    playerX_Score++;
                                    Player1_Score.Text = playerX_Score.ToString();
                                }
                                else
                                {
                                    playerO_Score++;
                                    Player2_Score.Text = playerO_Score.ToString();
                                }
                            }
                            break;
                    }
                    checkCounter++;
                }
                if (thereIsWinner)
                {
                    foreach (Control control in Game_Panel.Controls)
                    {
                        control.Enabled = false;
                    }
                    if (turn)
                    {
                        DialogResult win = MessageBox.Show($"Congratulations {player2Name}, You won this game! " +
                            $"\nCome on {player1Name}, Do you want to play again to win next game?",
                     "Tic-Tac-Toe Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (win == DialogResult.OK)
                        {
                            New.PerformClick();
                        }
                    }
                    else if(!turn)
                    {
                        DialogResult win = MessageBox.Show($"Congratulations {player1Name}, You won this game! " +
                            $"\nCome on {player2Name}, Do you want to play again to win next game?",
                     "Tic-Tac-Toe Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (win == DialogResult.OK)
                        {
                            New.PerformClick();
                        }
                    }
                }
            }
            else if (buttonCounter == 9)
            {
                DialogResult draw = MessageBox.Show("It's a draw! \nDo you want to play another game to break the draw?",
                     "Tic-Tac-Toe Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(draw == DialogResult.OK)
                {
                    New.PerformClick();
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            buttonCounter = 0;
            thereIsWinner = false;
            turn = true;
            foreach (Control control in Game_Panel.Controls)
            {
                control.Text = "";
                control.Enabled = true;
                control.BackColor = Color.DeepSkyBlue;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Are you sure you want to reset the scores and the game?",
                     "Tic-Tac-Toe Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reset == DialogResult.OK)
            {
                playerX_Score = 0;
                playerO_Score = 0;
                Player1_Score.Text = "0";
                Player2_Score.Text = "0";
                New.PerformClick();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to close the game and back to welcome page?",
                     "Tic-Tac-Toe Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (close == DialogResult.OK)
            {
                Welcome_Page welcome_Page = new Welcome_Page();
                welcome_Page.Show();
                this.Hide();
            }
        }

        private void Tic_Tac_Toe_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close.PerformClick();
        }
    }
}
