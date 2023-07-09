namespace Tac_Tac_Toe_Game
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
            this.Player2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(30, 200);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(230, 50);
            this.Player1.TabIndex = 6;
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(536, 200);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(230, 50);
            this.Player2.TabIndex = 7;
            // 
            // Tic_Tac_Toe_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tic_Tac_Toe_Game";
            this.Text = "Tic_Tac_Toe_Game";
            this.Load += new System.EventHandler(this.Tic_Tac_Toe_Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
    }
}