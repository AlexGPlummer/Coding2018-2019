using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        bool goup;
        bool godown;
        bool goup2;
        bool godown2;
        int speed = 5;
        int ballx = 5;
        int bally = 5;
        int player1score = 0;
        int player2score = 0;

        public Form1()
        {            
            InitializeComponent();                   
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup2 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown2 = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown2 = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            player1Score.Text = "" + player1score;
            player2Score.Text = "" + player2score;

            ball.Top -= bally;
            ball.Left -= ballx;

            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                player2score++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                player1score++;
            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballx = -ballx;
            }

            if (goup == true && player1.Top > 0)
            {
                player1.Top -= 8;
            }

            if (godown == true && player1.Top < 455)
            {
                player1.Top += 8;
            }

            if (goup2 == true && player2.Top > 0)
            {
                player2.Top -= 8;
            }

            if (godown2 == true && player2.Top < 455)
            {
                player2.Top -= 8;
            }

            if (player1score >= 10 && player1score - player2score != 1 && player2score - player1score != 1)
            {
                gameTimer.Stop();
                MessageBox.Show("Player 1 wins!");
            }

            if (player2score >= 10 && player1score - player2score != 1 && player2score - player1score != 1)
            {
                gameTimer.Stop();
                MessageBox.Show("Player 2 wins!");
            }
        }
    }
}
