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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            LevelSelect levelSelect = new LevelSelect();
            levelSelect.Show();
            this.Hide();
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
