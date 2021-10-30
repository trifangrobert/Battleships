using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class GameForm : Form
    {
        string connectionString;
        string currPath = Directory.GetCurrentDirectory(), basicPath;
        
        /// <summary>
        /// 0 -> questionMark
        /// 1 -> hit
        /// 2 -> miss
        /// </summary>
        int[,,] board;
        string player1Name, player2Name;
        int[,,] battleships;
        Image questionMarkImage, hitImage, missImage, battleshipImage;
        int who = 1, chosenCells = 5;
        bool settingBattleships = false;
        bool playingGame = false;
        List<Button> player1Buttons, player2Buttons;
        int cntHitsPlayer1 = 0;
        int cntMissPlayer1 = 0;
        int cntHitsPlayer2 = 0;
        int cntMissPlayer2 = 0;
        int winner;
        bool endGame = false;

        private void LoadImages()
        {
            questionMarkImage = Image.FromFile(basicPath + @"\Resources\questionmark.png");
            hitImage = Image.FromFile(basicPath + @"\Resources\hit.jpg");
            missImage = Image.FromFile(basicPath + @"\Resources\miss.jpg");
            battleshipImage = Image.FromFile(basicPath + @"\Resources\battleship.jpg");
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            player1Name = textBoxPlayer1Name.Text;
            player2Name = textBoxPlayer2Name.Text;
            if (player1Name != String.Empty && player2Name != String.Empty)
            {
                textBoxPlayer1Hits.Visible = true;
                textBoxPlayer1Misses.Visible = true;
                textBoxPlayer2Hits.Visible = true;
                textBoxPlayer2Misses.Visible = true;
                labelPlayer1Hits.Visible = true;
                labelPlayer2Hits.Visible = true;
                labelPlayer1Misses.Visible = true;
                labelPlayer2Misses.Visible = true;
                labelPlayer1Name.Text = player1Name;
                labelPlayer2Name.Text = player2Name;
                buttonStartGame.Visible = false;
                settingBattleships = true;
                textBoxPlayer1Name.Visible = false;
                textBoxPlayer2Name.Visible = false;
                ChooseBattleships(1);
            }
        }

        public GameForm()
        {
            basicPath = currPath.Remove(currPath.IndexOf("Battleships") + 11);
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + basicPath + @"\Database.mdf" + ";Integrated Security=True";
            Image background = Image.FromFile(basicPath + @"\Resources\backgroundGame2.jpg");
            InitializeComponent();
            this.BackgroundImage = background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ControlBox = false;
            LoadImages();
            PrepareGame();
        }


        private void ChooseBattleships(int player)
        {
            if (player == 1)
            {
                labelCommands.Text = player1Name + ", prepare your battleships!";
                labelPlayer1ShipsLeft.Visible = true;
                labelPlayer2ShipsLeft.Visible = false;
                panelPlayer1.Visible = true;
                panelPlayer2.Visible = false;
            }
            else
            {
                labelCommands.Text = player2Name + ", prepare your battleships!";
                labelPlayer1ShipsLeft.Visible = false;
                labelPlayer2ShipsLeft.Visible = true;
                panelPlayer1.Visible = false;
                panelPlayer2.Visible = true;

            }
        }
        private void PrepareGame()
        {
            player1Buttons = new List<Button>();
            player2Buttons = new List<Button>();
            int startX = 10, startY = 10;
            for (int i = 1, offSetX = 0;i <= 5; ++i, offSetX += 5)
            {
                for (int j = 1, offSetY = 0;j <= 5; ++j, offSetY += 5)
                {
                    int tag = 100 + i * 10 + j;
                    Button b = new Button();
                    b.Tag = tag;
                    b.Location = new Point(startX + 50 * (i - 1) + offSetX, startY + 50 * (j - 1) + offSetY);
                    b.Size = new Size(50, 50);
                    b.Visible = true;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.Click += new System.EventHandler(ClickedButton);
                    player1Buttons.Add(b);
                    //b.BackgroundImage = questionMarkImage;
                    panelPlayer1.Controls.Add(b);
                }
            }
            for (int i = 1, offSetX = 0; i <= 5; ++i, offSetX += 5)
            {
                for (int j = 1, offSetY = 0; j <= 5; ++j, offSetY += 5)
                {
                    int tag = 200 + i * 10 + j;
                    Button b = new Button();
                    b.Tag = tag;
                    b.Location = new Point(startX + 50 * (i - 1) + offSetX, startY + 50 * (j - 1) + offSetY);
                    b.Size = new Size(50, 50);
                    b.Visible = true;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.Click += new System.EventHandler(ClickedButton);
                    player2Buttons.Add(b);
                    //b.BackgroundImage = questionMarkImage;
                    panelPlayer2.Controls.Add(b);
                }
            }
            board = new int[3, 6, 6];
            battleships = new int[3, 6, 6];
            for (int p = 1;p <= 2; ++p)
            {
                for (int i = 1;i <= 5; ++i)
                {
                    for (int j = 1; j <= 5; ++j)
                        battleships[p, i, j] = board[p, i, j] = 0;
                }
            }
            panelPlayer1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelPlayer2.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelCommands.BackColor = Color.FromArgb(0, 0, 0, 0); 
            labelPlayer1Hits.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer1Misses.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer1Name.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer2Hits.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer2Misses.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer2Name.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer1ShipsLeft.Text = "Ships left: 5";
            labelPlayer1ShipsLeft.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelPlayer2ShipsLeft.Text = "Ships left: 5";
            labelPlayer2ShipsLeft.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelTurn.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelTurn.Text = String.Empty;
            labelTurn.Visible = false;

            labelCommands.Text = "Introduce your names:";
            panelPlayer1.Visible = false;
            panelPlayer2.Visible = false;
            labelPlayer1ShipsLeft.Visible = false;
            labelPlayer2ShipsLeft.Visible = false;
            buttonStartGame.BackColor = Color.Transparent;
            labelPlayer1Name.Text = String.Empty;
            labelPlayer2Name.Text = String.Empty;
            labelPlayer1Hits.Visible = false;
            labelPlayer2Hits.Visible = false;
            labelPlayer1Misses.Visible = false;
            labelPlayer2Misses.Visible = false;
            textBoxPlayer1Hits.Visible = false;
            textBoxPlayer1Misses.Visible = false;
            textBoxPlayer2Hits.Visible = false;
            textBoxPlayer2Misses.Visible = false;

        }

        public void ClickedButton(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (playingGame)
            {
                bool changeTurn = true;
                if (who == 1)
                {
                    int tag = Convert.ToInt32(button.Tag.ToString());
                    int x = tag / 10 % 10;
                    int y = tag % 10;
                    if (board[3 - who, x, y] == 0)
                    {
                        if (battleships[3 - who, x, y] == 1)
                        {
                            ///hit
                            ++cntHitsPlayer1;
                            button.BackgroundImage = hitImage;
                            textBoxPlayer1Hits.Text = cntHitsPlayer1.ToString();
                            board[3 - who, x, y] = 1;
                        }
                        else
                        {
                            ///miss
                            ++cntMissPlayer1;
                            button.BackgroundImage = missImage;
                            textBoxPlayer1Misses.Text = cntMissPlayer1.ToString();
                            board[3 - who, x, y] = 2;
                        }
                    }
                    else
                    {
                        changeTurn = false;
                        MessageBox.Show("You have already bombed this location, try another one!");
                        return;
                    }
                }
                else
                {
                    
                    int tag = Convert.ToInt32(button.Tag.ToString());
                    int x = tag / 10 % 10;
                    int y = tag % 10;
                    if (board[3 - who, x, y] == 0)
                    {
                        if (battleships[3 - who, x, y] == 1)
                        {
                            ///hit
                            ++cntHitsPlayer2;
                            button.BackgroundImage = hitImage;
                            textBoxPlayer2Hits.Text = cntHitsPlayer2.ToString();
                            board[3 - who, x, y] = 1;
                        }
                        else
                        {
                            ///miss
                            ++cntMissPlayer2;
                            button.BackgroundImage = missImage;
                            textBoxPlayer2Misses.Text = cntMissPlayer2.ToString();
                            board[3 - who, x, y] = 2;
                        }
                    }
                    else
                    {
                        changeTurn = false;
                        MessageBox.Show("You have already bombed this location, try another one!");
                        return;
                    }
                }
                if (changeTurn)
                {
                    if (who == 1)
                    {
                        foreach (Button b in player1Buttons)
                            b.Enabled = true;
                        foreach (Button b in player2Buttons)
                            b.Enabled = false;
                    }
                    else
                    {
                        foreach (Button b in player1Buttons)
                            b.Enabled = false;
                        foreach (Button b in player2Buttons)
                            b.Enabled = true;

                    }
                    who = 3 - who;
                    if (who == 1)
                        labelTurn.Text = player1Name + "'s turn";
                    else
                        labelTurn.Text = player2Name + "'s turn";
                }
                if (cntHitsPlayer1 == 5 || cntHitsPlayer2 == 5)
                {
                    if (cntHitsPlayer1 == 5)
                        winner = 1;
                    else
                        winner = 2;
                    playingGame = false;
                    foreach (Button b in player1Buttons)
                        b.Enabled = false;
                    foreach (Button b in player2Buttons)
                        b.Enabled = false;
                    endGame = true;
                    labelTurn.Visible = false;
                    if (winner == 1)
                        MessageBox.Show(player1Name + " is the winner!");
                    else
                        MessageBox.Show(player2Name + " is the winner!");
                    return;
                }
            }
            if (settingBattleships)
            {
                int tag = Convert.ToInt32(button.Tag.ToString());
                int x = tag / 10 % 10;
                int y = tag % 10;
                if (who == 1)
                {
                    if (battleships[1, x, y] == 0)
                    {
                        battleships[1, x, y] = 1;
                        button.BackgroundImage = battleshipImage;
                        --chosenCells;
                        labelPlayer1ShipsLeft.Text = "Ships left: " + chosenCells.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You have already placed a ship here, try another location");
                    }
                    if (chosenCells == 0)
                    {
                        chosenCells = 5;
                        ChooseBattleships(2);
                        who = 2;
                    }
                }
                else
                {
                    if (battleships[2, x, y] == 0)
                    {
                        battleships[2, x, y] = 1;
                        button.BackgroundImage = battleshipImage;
                        --chosenCells;
                        labelPlayer2ShipsLeft.Text = "Ships left: " + chosenCells.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You have already placed a ship here, try another location");
                    }
                    if (chosenCells == 0)
                    {
                        settingBattleships = false;
                        StartGame();
                        return;
                    }
                }
            }
            
        }

        private void StartGame()
        {
            labelPlayer1ShipsLeft.Visible = false;
            labelPlayer2ShipsLeft.Visible = false;
            labelCommands.TextAlign = ContentAlignment.MiddleCenter;
            labelCommands.Text = "";
            textBoxPlayer1Hits.Text = "0";
            textBoxPlayer1Misses.Text = "0";
            textBoxPlayer2Hits.Text = "0";
            textBoxPlayer2Misses.Text = "0";
            panelPlayer1.Visible = true;
            panelPlayer2.Visible = true;
            foreach (Button b in player1Buttons)
                b.BackgroundImage = questionMarkImage;
            foreach (Button b in player2Buttons)
                b.BackgroundImage = questionMarkImage;
            playingGame = true;
            who = 1;
            labelTurn.Visible = true;
            labelTurn.Text = player1Name + "'s turn";
            cntHitsPlayer1 = cntMissPlayer1 = cntHitsPlayer2 = cntMissPlayer2 = 0;
            foreach (Button b in player1Buttons)
                b.Enabled = false;
            foreach (Button b in player2Buttons)
                b.Enabled = true;
        }
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            if (endGame == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit? Your progress will be lost.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.ShowDialog();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    return;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save this score?", "Poseidon is asking", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string updateString = "INSERT INTO Scoreboard VALUES('" + player1Name + "', '" + cntHitsPlayer1 +
                            "', '" + cntMissPlayer1 + "', '" + player2Name + "', '" + cntHitsPlayer2 + "', '" + cntMissPlayer2 + "')";
                        SqlCommand command = new SqlCommand(updateString, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.ShowDialog();
                this.Close();
            }    
        }

    }
}
