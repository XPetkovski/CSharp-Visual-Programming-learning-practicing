using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint_1;
            foodImage = Properties.Resources.CoomerPacman;
            DoubleBuffered = true;
            NewGame();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = TIMER_INTERVAL - 1;
            if(TIMER_INTERVAL == 0)
            {
                timer1.Stop();
            }
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate(true);
        }

        public void NewGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.radius * 2 * (WORLD_HEIGHT + 1);

            foodWorld = new bool[WORLD_WIDTH][];
            for (int i = 0; i < WORLD_WIDTH; i++)
            {
                foodWorld[i] = new bool[WORLD_HEIGHT];
            }

                timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(Keys.Right != 0)
            {
                pacman.ChangeDirection("RIGHT");
            }
            if (Keys.Left != 0)
            {
                pacman.ChangeDirection("LEFT");
            }
            if (Keys.Up != 0)
            {
                pacman.ChangeDirection("UP");
            }
            if (Keys.Down != 0)
            {
                pacman.ChangeDirection("DOWN");
            }
            Invalidate(true);
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.radius * 2 + (Pacman.radius * 2 - foodImage.Height) / 2,
                            i * Pacman.radius * 2 + (Pacman.radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
            Invalidate(true);
        }
    }
}
