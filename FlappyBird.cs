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
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        bool gameOver = false;
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBirdP.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 855;
                score++;
            }

            if(flappyBirdP.Bounds.IntersectsWith(pipeBottom.Bounds) || 
               flappyBirdP.Bounds.IntersectsWith(pipeTop.Bounds) || 
               flappyBirdP.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (score > 10)
            {
                pipeSpeed = 10;
            }

            if(flappyBirdP.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

            if(e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
            if(e.KeyCode == Keys.G)
            {
                this.Hide();
                var game = new Form1();
                game.Show();
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " - Game Over! - Press R to retry!! Press G to go back in home page";
            gameOver = true;
        }

        private void RestartGame()
        {
            gameOver = false;
            
            flappyBirdP.Location = new Point(367, 260);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score: 0";
            
            gameTimer.Start();
        }
    }
}
