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
    public partial class SixtLevel : Form
    {
        bool goLeft, goRight, jumping, hasKey, hasCoin;

        int jumpSpeed = 5;
        int force = 4;

        int playerSpeed = 4;
        int backgroundSpeed = 4;

        public SixtLevel()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pbPlayer.Top += jumpSpeed;

            if (goLeft == true && pbPlayer.Left > 60)
            {
                pbPlayer.Left -= playerSpeed;
            }
            else if (goRight == true && pbPlayer.Left + (pbPlayer.Width + 60) < this.ClientSize.Width)
            {
                pbPlayer.Left += playerSpeed;
            }

            if (goLeft == true && pbBackground.Left < 0)
            {
                pbPlayer.Image = Properties.Resources.playerLeft;
                pbBackground.Left += backgroundSpeed;
                MoveGameElements("forward");
            }

            if (goRight == true && pbBackground.Left > -420)
            {
                pbPlayer.Image = Properties.Resources.player;
                pbBackground.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        pbPlayer.Top = x.Top - pbPlayer.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }
            }

            if (pbPlayer.Bounds.IntersectsWith(pbKey.Bounds))
            {
                pbKey.Visible = false;
                hasKey = true;
            }

            if (pbPlayer.Bounds.IntersectsWith(pbCoin.Bounds))
            {
                pbCoin.Visible = false;
                hasCoin = true;
            }


            if (pbPlayer.Bounds.IntersectsWith(pbDoorClosed.Bounds) && hasKey == true && hasCoin)
            {
                pbDoorClosed.Image = Properties.Resources.door_open;
                timer.Stop();
                MessageBox.Show("Well done, your journey is complete! " + Environment.NewLine + "Click Ok to play again");
                NextLevel();
            }

            if (pbPlayer.Top + pbPlayer.Height > ClientSize.Height)
            {
                timer.Stop();
                MessageBox.Show("You Died!" + Environment.NewLine + "Click Ok to play again this level");
                RestartGame(); 
            }
        }


        private void Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            else if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void UP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            else if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NextLevel()
        {
            MainMenu newWindow = new MainMenu();
            newWindow.Show();
            this.Hide();
        }

        private void RestartGame()
        {
            SixtLevel sameWindow = new SixtLevel();
            sameWindow.Show();
            this.Hide();
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "key" ||
                    x is PictureBox && (string)x.Tag == "door" || x is PictureBox && (string)x.Tag == "coin" ||
                     x is PictureBox && (string)x.Tag == "justBackground")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    else if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }
    }
}
