using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Battleships
{

    public partial class MenuForm : Form
    {

        string currPath = Directory.GetCurrentDirectory(), basicPath;
        public MenuForm()
        {
            basicPath = currPath.Remove(currPath.IndexOf("Battleships") + 11);
            Image background = Image.FromFile(basicPath + @"\Resources\backgroundStartMenu.jpg");
            InitializeComponent();
            this.BackgroundImage = background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStart.BackColor = Color.Transparent;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
            this.Close();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatsForm statsForm = new StatsForm();
            statsForm.ShowDialog();
            this.Close();
        }
    }
}
