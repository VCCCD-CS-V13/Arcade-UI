using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellPong
{
    public partial class Form6 : Form
    {
        bool goup;
        bool godown;
        int speed = 10;
        int ballx = 10;
        int bally = 15;
        int score = 0;
        int cpuPoint = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
            {
                new CSHARPDICEGAME.Form3().Show();
                this.Hide();
            }
            else
            {
                new CSHARPDICEGAME.Form3().Show();
                this.Hide();
            }
        }
        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = " " + score;
            cpuLabel.Text = " " + cpuPoint;
            ball.Top -= bally;
            ball.Left -= ballx;
            cpu.Top += speed;

            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 300)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top;

            }
            if (ball.Left <0)
            {
                ball.Left = 700;
                ballx = -ballx;
                ballx -= 2;
                cpuPoint++;


            }
            if (ball.Left + ball.Width > ClientSize.Width )
            {
                ball.Left = 700;
                ballx = -ballx;
                ballx += 2;
                score++;
            }
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height )
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }
            if (goup == true && player.Top > 0)
            {
                player.Top -= 25;
            }
            if (godown == true && player.Top <350)
            {
                player.Top += 25;
            }
            if (score>10)
            {
                gameTimer.Stop();
                MessageBox.Show("You WIN!");

            }
            if (cpuPoint > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You LOOSE! CPU WINS...");

            }

        }
    }
}
