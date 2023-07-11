﻿using System;
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
    public partial class Tic_Tac_Toe_Game : Form
    {
        string player1Name;
        string player2Name;
        int playerX_Score = 0;
        int playerO_Score = 0;
        int checkCounter = 0;
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
                }
                else
                {
                    winner = 'O';
                }
            }
            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                thereIsWinner = true;
                if (B1.Text == "X")
                {
                    winner = 'X';
                }
                else
                {
                    winner = 'O';
                }
            }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                thereIsWinner = true;
                if (C1.Text == "X")
                {
                    winner = 'X';
                }
                else
                {
                    winner = 'O';
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
                switch(checkCounter)
                {
                    case 0:
                        char winner = HorizontalCheck();
                        if (winner != '.')
                        {
                            if(winner == 'X')
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
            if(thereIsWinner)
            {
                foreach(Control control in Game_Panel.Controls)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
