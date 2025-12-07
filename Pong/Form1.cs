using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    //ball star=715,282
    
    public partial class Form1 : Form
    {
        bool P1_up, P1_down, P2_up, P2_down;
        int speed = 5;
        int directionX = 1;
        int directionY = 1;
        int player1Score = 0;
        int player2Score = 0;
        int touches = 0;
        SoundPlayer wall_hit = new SoundPlayer(Properties.Resources.wall_hit);
        SoundPlayer paddle_hit = new SoundPlayer(Properties.Resources.pallet_hit);
        SoundPlayer score = new SoundPlayer(Properties.Resources.score);
        void UpdateScore()
        {
            Score.Text = $"{player1Score}:{player2Score}";
            score.Play();
            speed = 5;
            touches = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Movement_Tick(object sender, EventArgs e)
        {
            ball.Left += speed * directionX;
            ball.Top += speed * directionY;
            if (ball.Top <= -2 || ball.Top>=this.ClientSize.Height-50) { directionY *= -1; wall_hit.Play(); }
            if(ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                directionX *= -1;
                paddle_hit.Play();
                touches++;
            }
            if(ball.Left <= -2)
            {
                player2Score++;
                ball.Location = new Point(715, 282);
                UpdateScore();
            }
            if (ball.Left >= this.ClientSize.Width)
            {
                player1Score++;
                ball.Location = new Point(715, 282);
                UpdateScore();
            }
            if(touches==5)
            {
                speed += 1;
                touches = 0;
            }    
        }

        private void Players_movement_Tick(object sender, EventArgs e)
        {
            if(P1_up && player2.Top > 0)
            {
                player2.Top -= 8;
            }
            if (P1_down && player2.Top < this.ClientSize.Height - player2.Height)
            {
                player2.Top += 8;
            }
            if (P2_up && player1.Top > 0)
            {
                player1.Top -= 8;
            }
            if (P2_down && player1.Top < this.ClientSize.Height - player1.Height)
            {
                player1.Top += 8;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ball.Location = new Point(715, 282);
            Movement.Start();
            Players_movement.Start();
            Score.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                P1_down = true;
            }
            if (e.KeyCode == Keys.W)
            {
                P1_up = true;
            }
            if (e.KeyCode == Keys.I)
            {
                P2_up=true;
            }
            if (e.KeyCode == Keys.K)
            {
                P2_down = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                P1_down = false;
            }
            if (e.KeyCode == Keys.W)
            {
                P1_up = false;
            }
            if (e.KeyCode == Keys.I)
            {
                P2_up = false;
            }
            if (e.KeyCode == Keys.K)
            {
                P2_down = false;
            }
        }
    }
}
