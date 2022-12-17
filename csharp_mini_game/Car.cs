using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_mini_game
{
    public partial class Car : Form
    {
        Random r = new Random();
        int x;

        int car_speed = 1;
        int game_score = 0;
        int move_control = 1;
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            moveline(car_speed);
            policeCar(3);
            gameover();
            money(car_speed);
            get_score();
        }

        void moveline(int speed) {
            if ( pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }

        private void Car_KeyDown(object sender, KeyEventArgs e)
        {
            if (move_control == 1)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (pictureBox_car.Left > 0)
                    {
                        pictureBox_car.Left -= 5;
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (pictureBox_car.Right < 400 - pictureBox_car.Width / 2)
                    {
                        pictureBox_car.Left += 5;
                    }

                }

                if (e.KeyCode == Keys.Up)
                {
                    if (car_speed < 15)
                    {
                        car_speed += 1;
                    }
                }
            }
        }
        void policeCar(int speed)
        {
            if (pictureBox_police.Top >= 500)
            {
                x = r.Next(0, 400);
                pictureBox_police.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_police.Top += speed;
            }

            if (pictureBox_police2.Top >= 500)
            {
                x = r.Next(100, 400);
                pictureBox_police2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_police2.Top += speed;
            }
        }
        void money(int speed)
        {
            if (pictureBox_money1.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_money1.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money1.Top += speed;
            }

            if (pictureBox_money2.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_money2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money2.Top += speed;
            }

            if (pictureBox_money3.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_money3.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money3.Top += speed;
            }
        }
        void get_score()
        {
            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_money1.Bounds))
            {
                game_score += 1;
                label2.Text  = "점수 = " + game_score.ToString();

                x = r.Next(0, 200);
                pictureBox_money1.Location = new Point(x, 0);
            }
            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_money2.Bounds))
            {
                game_score += 1;
                label2.Text = "점수 = " + game_score.ToString();

                x = r.Next(0, 200);
                pictureBox_money2.Location = new Point(x, 0);
            }
            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_money3.Bounds))
            {
                game_score += 1;
                label2.Text = "점수 = " + game_score.ToString();

                x = r.Next(0, 200);
                pictureBox_money3.Location = new Point(x, 0);
            }
        }
        void gameover()
        {

            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_police.Bounds) ||
                pictureBox_car.Bounds.IntersectsWith(pictureBox_police2.Bounds))
            {
                move_control = 0;
                timer1.Enabled = false;
                MessageBox.Show("점수 : " + game_score, "Game Over!!!");
                label1.Visible = true;
                Close();

            }
        }
    }
}
