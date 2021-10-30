
namespace Battleships
{
    partial class GameForm
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
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer1Hits = new System.Windows.Forms.Label();
            this.labelPlayer2Hits = new System.Windows.Forms.Label();
            this.labelPlayer1Misses = new System.Windows.Forms.Label();
            this.labelPlayer2Misses = new System.Windows.Forms.Label();
            this.textBoxPlayer1Hits = new System.Windows.Forms.TextBox();
            this.textBoxPlayer1Misses = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Hits = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Misses = new System.Windows.Forms.TextBox();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.labelCommands = new System.Windows.Forms.Label();
            this.labelPlayer1ShipsLeft = new System.Windows.Forms.Label();
            this.labelPlayer2ShipsLeft = new System.Windows.Forms.Label();
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(1052, 507);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(161, 54);
            this.buttonBackToMenu.TabIndex = 0;
            this.buttonBackToMenu.Text = "Back to menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Location = new System.Drawing.Point(57, 32);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(56, 17);
            this.labelPlayer1Name.TabIndex = 3;
            this.labelPlayer1Name.Text = "Player1";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Location = new System.Drawing.Point(755, 32);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(56, 17);
            this.labelPlayer2Name.TabIndex = 4;
            this.labelPlayer2Name.Text = "Player2";
            // 
            // labelPlayer1Hits
            // 
            this.labelPlayer1Hits.AutoSize = true;
            this.labelPlayer1Hits.Location = new System.Drawing.Point(167, 32);
            this.labelPlayer1Hits.Name = "labelPlayer1Hits";
            this.labelPlayer1Hits.Size = new System.Drawing.Size(32, 17);
            this.labelPlayer1Hits.TabIndex = 5;
            this.labelPlayer1Hits.Text = "Hits";
            // 
            // labelPlayer2Hits
            // 
            this.labelPlayer2Hits.AutoSize = true;
            this.labelPlayer2Hits.Location = new System.Drawing.Point(860, 32);
            this.labelPlayer2Hits.Name = "labelPlayer2Hits";
            this.labelPlayer2Hits.Size = new System.Drawing.Size(32, 17);
            this.labelPlayer2Hits.TabIndex = 6;
            this.labelPlayer2Hits.Text = "Hits";
            // 
            // labelPlayer1Misses
            // 
            this.labelPlayer1Misses.AutoSize = true;
            this.labelPlayer1Misses.Location = new System.Drawing.Point(324, 32);
            this.labelPlayer1Misses.Name = "labelPlayer1Misses";
            this.labelPlayer1Misses.Size = new System.Drawing.Size(51, 17);
            this.labelPlayer1Misses.TabIndex = 7;
            this.labelPlayer1Misses.Text = "Misses";
            // 
            // labelPlayer2Misses
            // 
            this.labelPlayer2Misses.AutoSize = true;
            this.labelPlayer2Misses.Location = new System.Drawing.Point(1049, 32);
            this.labelPlayer2Misses.Name = "labelPlayer2Misses";
            this.labelPlayer2Misses.Size = new System.Drawing.Size(51, 17);
            this.labelPlayer2Misses.TabIndex = 8;
            this.labelPlayer2Misses.Text = "Misses";
            // 
            // textBoxPlayer1Hits
            // 
            this.textBoxPlayer1Hits.Enabled = false;
            this.textBoxPlayer1Hits.Location = new System.Drawing.Point(205, 29);
            this.textBoxPlayer1Hits.Name = "textBoxPlayer1Hits";
            this.textBoxPlayer1Hits.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer1Hits.TabIndex = 9;
            // 
            // textBoxPlayer1Misses
            // 
            this.textBoxPlayer1Misses.Enabled = false;
            this.textBoxPlayer1Misses.Location = new System.Drawing.Point(381, 29);
            this.textBoxPlayer1Misses.Name = "textBoxPlayer1Misses";
            this.textBoxPlayer1Misses.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer1Misses.TabIndex = 10;
            // 
            // textBoxPlayer2Hits
            // 
            this.textBoxPlayer2Hits.Enabled = false;
            this.textBoxPlayer2Hits.Location = new System.Drawing.Point(898, 29);
            this.textBoxPlayer2Hits.Name = "textBoxPlayer2Hits";
            this.textBoxPlayer2Hits.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer2Hits.TabIndex = 11;
            // 
            // textBoxPlayer2Misses
            // 
            this.textBoxPlayer2Misses.Enabled = false;
            this.textBoxPlayer2Misses.Location = new System.Drawing.Point(1106, 29);
            this.textBoxPlayer2Misses.Name = "textBoxPlayer2Misses";
            this.textBoxPlayer2Misses.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer2Misses.TabIndex = 12;
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.Location = new System.Drawing.Point(60, 82);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(390, 360);
            this.panelPlayer1.TabIndex = 13;
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPlayer2.Location = new System.Drawing.Point(758, 82);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(390, 360);
            this.panelPlayer2.TabIndex = 14;
            // 
            // labelCommands
            // 
            this.labelCommands.AutoSize = true;
            this.labelCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommands.Location = new System.Drawing.Point(468, 456);
            this.labelCommands.Name = "labelCommands";
            this.labelCommands.Size = new System.Drawing.Size(79, 29);
            this.labelCommands.TabIndex = 15;
            this.labelCommands.Text = "blabla";
            // 
            // labelPlayer1ShipsLeft
            // 
            this.labelPlayer1ShipsLeft.AutoSize = true;
            this.labelPlayer1ShipsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1ShipsLeft.Location = new System.Drawing.Point(215, 498);
            this.labelPlayer1ShipsLeft.Name = "labelPlayer1ShipsLeft";
            this.labelPlayer1ShipsLeft.Size = new System.Drawing.Size(64, 25);
            this.labelPlayer1ShipsLeft.TabIndex = 16;
            this.labelPlayer1ShipsLeft.Text = "label1";
            this.labelPlayer1ShipsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2ShipsLeft
            // 
            this.labelPlayer2ShipsLeft.AutoSize = true;
            this.labelPlayer2ShipsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2ShipsLeft.Location = new System.Drawing.Point(911, 498);
            this.labelPlayer2ShipsLeft.Name = "labelPlayer2ShipsLeft";
            this.labelPlayer2ShipsLeft.Size = new System.Drawing.Size(64, 25);
            this.labelPlayer2ShipsLeft.TabIndex = 17;
            this.labelPlayer2ShipsLeft.Text = "label2";
            this.labelPlayer2ShipsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(447, 502);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer1Name.TabIndex = 18;
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(620, 501);
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer2Name.TabIndex = 19;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(536, 538);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(111, 29);
            this.buttonStartGame.TabIndex = 20;
            this.buttonStartGame.Text = "Start game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.Location = new System.Drawing.Point(516, 206);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(79, 29);
            this.labelTurn.TabIndex = 21;
            this.labelTurn.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1229, 579);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.textBoxPlayer2Name);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Controls.Add(this.labelPlayer2ShipsLeft);
            this.Controls.Add(this.labelPlayer1ShipsLeft);
            this.Controls.Add(this.labelCommands);
            this.Controls.Add(this.panelPlayer2);
            this.Controls.Add(this.panelPlayer1);
            this.Controls.Add(this.textBoxPlayer2Misses);
            this.Controls.Add(this.textBoxPlayer2Hits);
            this.Controls.Add(this.textBoxPlayer1Misses);
            this.Controls.Add(this.textBoxPlayer1Hits);
            this.Controls.Add(this.labelPlayer2Misses);
            this.Controls.Add(this.labelPlayer1Misses);
            this.Controls.Add(this.labelPlayer2Hits);
            this.Controls.Add(this.labelPlayer1Hits);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.buttonBackToMenu);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer1Hits;
        private System.Windows.Forms.Label labelPlayer2Hits;
        private System.Windows.Forms.Label labelPlayer1Misses;
        private System.Windows.Forms.Label labelPlayer2Misses;
        private System.Windows.Forms.TextBox textBoxPlayer1Hits;
        private System.Windows.Forms.TextBox textBoxPlayer1Misses;
        private System.Windows.Forms.TextBox textBoxPlayer2Hits;
        private System.Windows.Forms.TextBox textBoxPlayer2Misses;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Label labelCommands;
        private System.Windows.Forms.Label labelPlayer1ShipsLeft;
        private System.Windows.Forms.Label labelPlayer2ShipsLeft;
        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.TextBox textBoxPlayer2Name;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelTurn;
    }
}