﻿namespace Tac_Tac_Toe_Game
{
    partial class Tic_Tac_Toe_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tic_Tac_Toe_Game));
            this.Player1 = new System.Windows.Forms.Label();
            this.Player1_Score = new System.Windows.Forms.Label();
            this.Game_Panel = new System.Windows.Forms.Panel();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.Score_Panel = new System.Windows.Forms.Panel();
            this.Player2_Score = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Button_Panel = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.turn_ = new System.Windows.Forms.Label();
            this.Game_Panel.SuspendLayout();
            this.Score_Panel.SuspendLayout();
            this.Button_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(19, 96);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(270, 60);
            this.Player1.TabIndex = 6;
            this.Player1.Text = "Player X :";
            // 
            // Player1_Score
            // 
            this.Player1_Score.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_Score.Location = new System.Drawing.Point(295, 103);
            this.Player1_Score.Name = "Player1_Score";
            this.Player1_Score.Size = new System.Drawing.Size(160, 50);
            this.Player1_Score.TabIndex = 7;
            this.Player1_Score.Text = "0";
            // 
            // Game_Panel
            // 
            this.Game_Panel.Controls.Add(this.C3);
            this.Game_Panel.Controls.Add(this.C2);
            this.Game_Panel.Controls.Add(this.C1);
            this.Game_Panel.Controls.Add(this.B3);
            this.Game_Panel.Controls.Add(this.B2);
            this.Game_Panel.Controls.Add(this.B1);
            this.Game_Panel.Controls.Add(this.A3);
            this.Game_Panel.Controls.Add(this.A2);
            this.Game_Panel.Controls.Add(this.A1);
            this.Game_Panel.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Panel.Location = new System.Drawing.Point(12, 12);
            this.Game_Panel.Name = "Game_Panel";
            this.Game_Panel.Size = new System.Drawing.Size(679, 651);
            this.Game_Panel.TabIndex = 8;
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.C3.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(455, 435);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(220, 210);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.C2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(229, 435);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(220, 210);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.C1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(3, 435);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(220, 210);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.B3.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(455, 219);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(220, 210);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.B2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(229, 219);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(220, 210);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.B1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(3, 219);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(220, 210);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.A3.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(455, 3);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(220, 210);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.A2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(229, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(220, 210);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.A1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(3, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(220, 210);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // Score_Panel
            // 
            this.Score_Panel.Controls.Add(this.turn_);
            this.Score_Panel.Controls.Add(this.Player2_Score);
            this.Score_Panel.Controls.Add(this.Player2);
            this.Score_Panel.Controls.Add(this.label);
            this.Score_Panel.Controls.Add(this.Player1_Score);
            this.Score_Panel.Controls.Add(this.Player1);
            this.Score_Panel.Location = new System.Drawing.Point(697, 12);
            this.Score_Panel.Name = "Score_Panel";
            this.Score_Panel.Size = new System.Drawing.Size(473, 429);
            this.Score_Panel.TabIndex = 9;
            // 
            // Player2_Score
            // 
            this.Player2_Score.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_Score.Location = new System.Drawing.Point(295, 226);
            this.Player2_Score.Name = "Player2_Score";
            this.Player2_Score.Size = new System.Drawing.Size(162, 50);
            this.Player2_Score.TabIndex = 12;
            this.Player2_Score.Text = "0";
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(19, 219);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(268, 60);
            this.Player2.TabIndex = 11;
            this.Player2.Text = "Player O :";
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(180, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 38);
            this.label.TabIndex = 10;
            this.label.Text = "Scores";
            // 
            // Button_Panel
            // 
            this.Button_Panel.Controls.Add(this.Close);
            this.Button_Panel.Controls.Add(this.Reset);
            this.Button_Panel.Controls.Add(this.New);
            this.Button_Panel.Location = new System.Drawing.Point(697, 447);
            this.Button_Panel.Name = "Button_Panel";
            this.Button_Panel.Size = new System.Drawing.Size(473, 216);
            this.Button_Panel.TabIndex = 10;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(138, 134);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(207, 60);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close Game";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(248, 44);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(207, 60);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset Game";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(16, 44);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(207, 60);
            this.New.TabIndex = 0;
            this.New.Text = "New Game";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // turn_
            // 
            this.turn_.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn_.Location = new System.Drawing.Point(110, 350);
            this.turn_.Name = "turn_";
            this.turn_.Size = new System.Drawing.Size(270, 60);
            this.turn_.TabIndex = 13;
            this.turn_.Text = " ";
            // 
            // Tic_Tac_Toe_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.Button_Panel);
            this.Controls.Add(this.Score_Panel);
            this.Controls.Add(this.Game_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Tic_Tac_Toe_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic_Tac_Toe_2 Players";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tic_Tac_Toe_Game_FormClosing);
            this.Load += new System.EventHandler(this.Tic_Tac_Toe_Game_Load);
            this.Game_Panel.ResumeLayout(false);
            this.Score_Panel.ResumeLayout(false);
            this.Button_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player1_Score;
        private System.Windows.Forms.Panel Game_Panel;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Panel Score_Panel;
        private System.Windows.Forms.Label Player2_Score;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel Button_Panel;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label turn_;
    }
}