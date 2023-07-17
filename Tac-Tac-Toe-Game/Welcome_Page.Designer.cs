namespace Tac_Tac_Toe_Game
{
    partial class Welcome_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.btn_AI_version = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Tic Tac Toe Game";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enjoy Your Time";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player1 Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(548, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player2 Name";
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Player1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.Color.MediumBlue;
            this.Player1.Location = new System.Drawing.Point(38, 225);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(190, 38);
            this.Player1.TabIndex = 7;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Player2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Player2.ForeColor = System.Drawing.Color.MediumBlue;
            this.Player2.Location = new System.Drawing.Point(567, 227);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(190, 38);
            this.Player2.TabIndex = 8;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Start.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(12, 374);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(214, 67);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start Game With 2 Players";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(576, 380);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(214, 61);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close App";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // btn_AI_version
            // 
            this.btn_AI_version.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AI_version.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AI_version.ForeColor = System.Drawing.Color.White;
            this.btn_AI_version.Location = new System.Drawing.Point(232, 374);
            this.btn_AI_version.Name = "btn_AI_version";
            this.btn_AI_version.Size = new System.Drawing.Size(214, 67);
            this.btn_AI_version.TabIndex = 11;
            this.btn_AI_version.Text = "Start Game Against AI";
            this.btn_AI_version.UseVisualStyleBackColor = false;
            this.btn_AI_version.Click += new System.EventHandler(this.btn_AI_version_Click);
            this.btn_AI_version.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.btn_AI_version.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // Welcome_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.btn_AI_version);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Welcome_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Tic-Tac-Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_Page_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btn_AI_version;
    }
}

