using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesProject
{
    public partial class GravityRunGame : Form
    {
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;

        bool gameOver = false;

        Random random = new Random();

        public GravityRunGame()
        {
            InitializeComponent();
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            lblhighScore.Text = "High Score: " + highScore;

            player.Top += gravity;

            if(player.Top > 400)
            {
                gravity = 0;
                player.Top = 400;
                player.Image = Properties.Resources.run_down0;
            }

            else if(player.Top < 50)
            {
                gravity = 0;
                player.Top = 50;
                player.Image = Properties.Resources.run_up0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if(x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }

                    if(x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameTimer.Stop();
                        goBack.Enabled = true;
                        lblScore.Text += "  - Game Over!!! Press Enter to Restart the Game";
                        gameOver = true;

                        if(score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }

            if(score > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if(player.Top == 400)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                }

                else if(player.Top == 50)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                }
            }

            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void RestartGame()
        {
            lblScore.Parent = pictureBox1;
            lblhighScore.Parent = pictureBox2;
            lblhighScore.Top = 0;
            player.Location = new Point(180, 149);
            player.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }

            gameTimer.Start();
            goBack.Enabled = false;

        }

        private void gohome(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var game = new Form1();
            game.Show();
        }
    }
}
