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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string player1Name = Player1.Text;
            string player2Name = Player2.Text;
            Tic_Tac_Toe_Game tic_Tac_Toe = new Tic_Tac_Toe_Game(player1Name, player2Name);
            tic_Tac_Toe.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close app?", "Tic Tac Toe Game"
                 , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.SteelBlue;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DeepSkyBlue;
        }
    }
}
