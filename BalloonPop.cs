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
    public partial class BalloonPop : Form
    {
        int speed;
        int score;
        Random rand = new Random();
        bool gameOver;

        public BalloonPop()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if(gameOver == true)
            {
                gameTimer.Stop();
                goBack.Enabled = true;
                txtScore.Text = "Score: " + score + "  Game Over!-Press enter to restart!";
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Top -= speed;

                    if(x.Top < -100)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 500);
                    }

                    if((string)x.Tag == "balloon")
                    {
                        if(x.Top < -50)
                        {
                            gameOver = true;
                        }

                        if(bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = rand.Next(700, 1000);
                            x.Left = rand.Next(5, 500);
                        }
                    }
                }
            }
            if(score > 5)
            {
                speed = 6;
            }

            if(score > 15 && score < 25)
            {
                speed = 8;
            }
        }

        private void PopBalloon(object sender, EventArgs e)
        {
            if(gameOver == false)
            {
                var balloon = (PictureBox)sender;

                balloon.Top = rand.Next(750, 1000);
                balloon.Left = rand.Next(5, 500);

                score += 1;
            }
        }

        private void GoBoom(object sender, EventArgs e)
        {
            if(gameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                gameOver = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            speed = 5;
            score = 0;
            gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox) 
                {
                    x.Top = rand.Next(750,1000);
                    x.Left = rand.Next(5, 500);
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
