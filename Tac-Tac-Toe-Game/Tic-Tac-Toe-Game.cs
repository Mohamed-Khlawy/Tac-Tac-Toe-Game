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
    public partial class Tic_Tac_Toe_Game : Form
    {
        string player1Name;
        string player2Name;
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

        
    }
}
