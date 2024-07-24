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
    public partial class TicTacToe : Form
    {
        public enum Player
        {
            X,O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        public TicTacToe()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if(buttons.Count >0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.PeachPuff;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text= currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.White;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if(b1.Text == "X" && b2.Text == "X" && b3.Text == "X"
                || b4.Text == "X" && b5.Text == "X" && b6.Text == "X"
                || b7.Text == "X" && b8.Text == "X" && b9.Text == "X"
                || b1.Text == "X" && b4.Text == "X" && b7.Text == "X"
                || b2.Text == "X" && b5.Text == "X" && b8.Text == "X"
                || b3.Text == "X" && b6.Text == "X" && b9.Text == "X"
                || b1.Text == "X" && b5.Text == "X" && b9.Text == "X"
                || b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins!");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();

            }

            else if(b1.Text == "O" && b2.Text == "O" && b3.Text == "O"
                || b4.Text == "O" && b5.Text == "O" && b6.Text == "O"
                || b7.Text == "O" && b8.Text == "O" && b9.Text == "O"
                || b1.Text == "O" && b4.Text == "O" && b7.Text == "O"
                || b2.Text == "O" && b5.Text == "O" && b8.Text == "O"
                || b3.Text == "O" && b6.Text == "O" && b9.Text == "O"
                || b1.Text == "O" && b5.Text == "O" && b9.Text == "O"
                || b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("Computer Wins!");
                CPUWinCount++;
                label2.Text = "Computer Wins: " + CPUWinCount;
                RestartGame();
            }
        }
        
        private void RestartGame()
        {
            buttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };


            foreach(Button x in buttons) 
            {
                x.Enabled = true;
                x.Text = "  ";
                x.BackColor = Color.PapayaWhip; 
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var game = new Form1();
            game.Show();
        }
    }
}
