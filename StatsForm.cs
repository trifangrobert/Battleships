using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Battleships
{
    public partial class StatsForm : Form
    {
        string connectionString;
        string currPath = Directory.GetCurrentDirectory(), basicPath;
        public StatsForm()
        {
            basicPath = currPath.Remove(currPath.IndexOf("Battleships") + 11);
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + basicPath + @"\Database.mdf" + ";Integrated Security=True";
            Image background = Image.FromFile(basicPath + @"\Resources\backgroundStats.jpg");
            InitializeComponent();
            this.ControlBox = false;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = background;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            /*listBoxPlayer1.BackColor = Color.FromArgb(100, 0, 0, 0);
            listBoxPlayer1Hits.BackColor = Color.FromArgb(100, 0, 0, 0);
            listBoxPlayer1Misses.BackColor = Color.FromArgb(100, 0, 0, 0);
            listBoxPlayer2.BackColor = Color.FromArgb(100, 0, 0, 0);
            listBoxPlayer2Hits.BackColor = Color.FromArgb(100, 0, 0, 0);
            listBoxPlayer2Misses.BackColor = Color.FromArgb(100, 0, 0, 0);*/
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset all your data? You cannot restore it.", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBoxPlayer1.Items.Clear();
                listBoxPlayer1Hits.Items.Clear();
                listBoxPlayer1Misses.Items.Clear();
                listBoxPlayer2.Items.Clear();
                listBoxPlayer2Hits.Items.Clear();
                listBoxPlayer2Misses.Items.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateString = "DELETE FROM Scoreboard";
                    SqlCommand command = new SqlCommand(updateString, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void buttonShowGames_Click(object sender, EventArgs e)
        {
            listBoxPlayer1.Items.Clear();
            listBoxPlayer1Hits.Items.Clear();
            listBoxPlayer1Misses.Items.Clear();
            listBoxPlayer2.Items.Clear();
            listBoxPlayer2Hits.Items.Clear();
            listBoxPlayer2Misses.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT * FROM Scoreboard";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBoxPlayer1.Items.Add(reader[1].ToString());
                    listBoxPlayer1Hits.Items.Add(reader[2].ToString());
                    listBoxPlayer1Misses.Items.Add(reader[3].ToString());

                    listBoxPlayer2.Items.Add(reader[4].ToString());
                    listBoxPlayer2Hits.Items.Add(reader[5].ToString());
                    listBoxPlayer2Misses.Items.Add(reader[6].ToString());
                }
                reader.Close();
                connection.Close();
            }
        }

    }
}
