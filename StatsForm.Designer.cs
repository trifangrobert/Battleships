
namespace Battleships
{
    partial class StatsForm
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
            this.buttonShowGames = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxPlayer1 = new System.Windows.Forms.ListBox();
            this.listBoxPlayer1Hits = new System.Windows.Forms.ListBox();
            this.listBoxPlayer1Misses = new System.Windows.Forms.ListBox();
            this.listBoxPlayer2 = new System.Windows.Forms.ListBox();
            this.listBoxPlayer2Hits = new System.Windows.Forms.ListBox();
            this.listBoxPlayer2Misses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(828, 434);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(180, 59);
            this.buttonBackToMenu.TabIndex = 0;
            this.buttonBackToMenu.Text = "Back to menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // buttonShowGames
            // 
            this.buttonShowGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowGames.Location = new System.Drawing.Point(63, 71);
            this.buttonShowGames.Name = "buttonShowGames";
            this.buttonShowGames.Size = new System.Drawing.Size(160, 57);
            this.buttonShowGames.TabIndex = 1;
            this.buttonShowGames.Text = "Show games";
            this.buttonShowGames.UseVisualStyleBackColor = true;
            this.buttonShowGames.Click += new System.EventHandler(this.buttonShowGames_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(63, 354);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(160, 57);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // listBoxPlayer1
            // 
            this.listBoxPlayer1.FormattingEnabled = true;
            this.listBoxPlayer1.ItemHeight = 16;
            this.listBoxPlayer1.Location = new System.Drawing.Point(413, 71);
            this.listBoxPlayer1.Name = "listBoxPlayer1";
            this.listBoxPlayer1.Size = new System.Drawing.Size(74, 340);
            this.listBoxPlayer1.TabIndex = 3;
            // 
            // listBoxPlayer1Hits
            // 
            this.listBoxPlayer1Hits.FormattingEnabled = true;
            this.listBoxPlayer1Hits.ItemHeight = 16;
            this.listBoxPlayer1Hits.Location = new System.Drawing.Point(516, 71);
            this.listBoxPlayer1Hits.Name = "listBoxPlayer1Hits";
            this.listBoxPlayer1Hits.Size = new System.Drawing.Size(40, 340);
            this.listBoxPlayer1Hits.TabIndex = 4;
            // 
            // listBoxPlayer1Misses
            // 
            this.listBoxPlayer1Misses.FormattingEnabled = true;
            this.listBoxPlayer1Misses.ItemHeight = 16;
            this.listBoxPlayer1Misses.Location = new System.Drawing.Point(583, 71);
            this.listBoxPlayer1Misses.Name = "listBoxPlayer1Misses";
            this.listBoxPlayer1Misses.Size = new System.Drawing.Size(40, 340);
            this.listBoxPlayer1Misses.TabIndex = 5;
            // 
            // listBoxPlayer2
            // 
            this.listBoxPlayer2.FormattingEnabled = true;
            this.listBoxPlayer2.ItemHeight = 16;
            this.listBoxPlayer2.Location = new System.Drawing.Point(687, 71);
            this.listBoxPlayer2.Name = "listBoxPlayer2";
            this.listBoxPlayer2.Size = new System.Drawing.Size(74, 340);
            this.listBoxPlayer2.TabIndex = 6;
            // 
            // listBoxPlayer2Hits
            // 
            this.listBoxPlayer2Hits.FormattingEnabled = true;
            this.listBoxPlayer2Hits.ItemHeight = 16;
            this.listBoxPlayer2Hits.Location = new System.Drawing.Point(797, 71);
            this.listBoxPlayer2Hits.Name = "listBoxPlayer2Hits";
            this.listBoxPlayer2Hits.Size = new System.Drawing.Size(40, 340);
            this.listBoxPlayer2Hits.TabIndex = 7;
            // 
            // listBoxPlayer2Misses
            // 
            this.listBoxPlayer2Misses.FormattingEnabled = true;
            this.listBoxPlayer2Misses.ItemHeight = 16;
            this.listBoxPlayer2Misses.Location = new System.Drawing.Point(867, 71);
            this.listBoxPlayer2Misses.Name = "listBoxPlayer2Misses";
            this.listBoxPlayer2Misses.Size = new System.Drawing.Size(40, 340);
            this.listBoxPlayer2Misses.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Misses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Misses";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 505);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlayer2Misses);
            this.Controls.Add(this.listBoxPlayer2Hits);
            this.Controls.Add(this.listBoxPlayer2);
            this.Controls.Add(this.listBoxPlayer1Misses);
            this.Controls.Add(this.listBoxPlayer1Hits);
            this.Controls.Add(this.listBoxPlayer1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonShowGames);
            this.Controls.Add(this.buttonBackToMenu);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Button buttonShowGames;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxPlayer1;
        private System.Windows.Forms.ListBox listBoxPlayer1Hits;
        private System.Windows.Forms.ListBox listBoxPlayer1Misses;
        private System.Windows.Forms.ListBox listBoxPlayer2;
        private System.Windows.Forms.ListBox listBoxPlayer2Hits;
        private System.Windows.Forms.ListBox listBoxPlayer2Misses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}