using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tac_Tac_Toe_Game
{
    public partial class AI_Version : Form
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
        List<Button> GameButtons = new List<Button>();
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
        private void CreateButtonList()
        {
            GameButtons.Clear();

            GameButtons.Add(A1);
            GameButtons.Add(A2);
            GameButtons.Add(A3);
            GameButtons.Add(B1);
            GameButtons.Add(B2);
            GameButtons.Add(B3);
            GameButtons.Add(C1);
            GameButtons.Add(C2);
            GameButtons.Add(C3);
            //foreach(Button button in Game_Panel.Controls)
            //{
            //    GameButtons.Add(button);
            //}
        }
        public AI_Version(string player1Name_, string player2Name_)
        {
            if (player1Name_ == "")
            {
                player1Name_ = "Player X";
            }
            if (player2Name_ == "")
            {
                player2Name_ = "AI";
            }
            player1Name = player1Name_;
            player2Name = player2Name_;
            InitializeComponent();
        }

        private void AI_Version_Load(object sender, EventArgs e)
        {
            Player1.Text = player1Name + " :";
            Player2.Text = player2Name + " :";
            CreateButtonList();
            turn_.Text = $"{player1Name} Turn";
        }
        private void btnGame_Click(object sender, EventArgs e)
        {
            buttonCounter++;
            if(buttonCounter > 9)
            {
                if (turn)
                {

                }
                else
                {

                }
            }
        }
    }
}
