using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePlatformPlatformerGame
{
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnLvl1_Click(object sender, EventArgs e)
        {
            FirstLevel firstLevel = new FirstLevel();
            firstLevel.Show();
            this.Hide();
        }

        private void btnLvl2_Click(object sender, EventArgs e)
        {
            SecondLevel secondLevel = new SecondLevel();
            secondLevel.Show();
            this.Hide();
        }

        private void btnLvl3_Click(object sender, EventArgs e)
        {
            ThirdLevel thirdLevel = new ThirdLevel();
            thirdLevel.Show();
            this.Hide();
        }

        private void btnLvl4_Click(object sender, EventArgs e)
        {
            FourthLevel fourthLevel = new FourthLevel();
            fourthLevel.Show();
            this.Hide();
        }

        private void btnLvl5_Click(object sender, EventArgs e)
        {
            FifthLevel fifthLevel = new FifthLevel();
            fifthLevel.Show();
            this.Hide();
        }

        private void btnLvl6_Click(object sender, EventArgs e)
        {
            SixtLevel sixtLevel = new SixtLevel();
            sixtLevel.Show();
            this.Hide();
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
