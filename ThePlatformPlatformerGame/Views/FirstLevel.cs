using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ThePlatformPlatformerGame
{
    public partial class FirstLevel : Form
    {
        bool goLeft, goRight, jumping;

        int jumpSpeed = 5;
        int force = 4;

        int playerSpeed = 4;
        int backgroundSpeed = 4;

        public FirstLevel()
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

            if (goRight == true && pbBackground.Left > -970)
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

            if (jumping == true && force < 3)
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

            if (pbPlayer.Top + pbPlayer.Height > ClientSize.Height)
            {
                timer.Stop();
                MessageBox.Show("You Died!" + Environment.NewLine + "Click Ok to play again");
                RestartGame();
            }

            if (pbPlayer.Bounds.IntersectsWith(pbDoorOpen.Bounds))
            {
                timer.Stop();
                MessageBox.Show("Well done, your journey here is complete! " + Environment.NewLine + "Click Ok to play the next level");

                SecondLevel secondLevel = new SecondLevel();
                secondLevel.Show();
                this.Hide();
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

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            SecondLevel newWindow = new SecondLevel();
            newWindow.Show();
            this.Hide();
        }
        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "key" ||
                    x is PictureBox && (string)x.Tag == "door")
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