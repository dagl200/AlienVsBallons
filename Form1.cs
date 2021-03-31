using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo
{
    public partial class Form1 : Form
    {
        int tick = 0;
        public static int highscore = 0;
        Stopwatch time = new Stopwatch();
        Random aleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
            pictureBox6.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            time.Start();

        }

        private void Win()
        {
            if (highscore > 500)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                Form form1 = new Form1();
                form1.Dispose();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (pictureBox3.Visible)
                {

                    if (pictureBox2.Top < pictureBox3.Top && (pictureBox2.Top + 100) > pictureBox3.Top)
                    {
                        progressBar1.Value += 10;
                        pictureBox2.Top = 900;
                        pictureBox2.Left = aleatorio.Next(100, 600);
                        highscore += 10;
                    }
                    if (pictureBox12.Top < pictureBox3.Top && (pictureBox12.Top + 100) > pictureBox3.Top)
                    {
                        progressBar1.Value += 10;
                        pictureBox12.Top = 900;
                        pictureBox12.Left = aleatorio.Next(100, 600);
                        highscore += 10;
                    }
                    if (pictureBox9.Top < pictureBox3.Top && (pictureBox9.Top + 100) > pictureBox3.Top)
                    {
                        progressBar1.Value += 10;
                        pictureBox9.Top = 900;
                        pictureBox9.Left = aleatorio.Next(100, 600);
                        highscore += 10;
                    }
                    if (pictureBox4.Top < pictureBox3.Top && (pictureBox4.Top + 100) > pictureBox3.Top)
                    {
                        progressBar1.Value++;
                        pictureBox4.Top = 900;
                        pictureBox4.Left = aleatorio.Next(100, 600);
                        highscore += 1;
                    }
                    if (pictureBox5.Top < pictureBox3.Top && (pictureBox5.Top + 100) > pictureBox3.Top)
                    {
                        progressBar1.Value++;
                        pictureBox5.Top = 900;
                        pictureBox5.Left = aleatorio.Next(100, 600);
                        highscore += 1;
                    }
                    tick++;


                    pictureBox3.Visible = false;
                    tick = 0;
                }
            
            
            

        }
         
        private void timer2_Tick(object sender, EventArgs e)
        {
            ballonsMove();
            label2.Text = highscore.ToString();
            shipOutOfBounds();
            TimeSpan otherTime = time.Elapsed;
            label3.Text = String.Format("{0:00}:{1:00}:{2:00}",
            otherTime.Minutes, otherTime.Seconds,
            otherTime.Milliseconds / 10);
            Win();
        }

        private void shipOutOfBounds()
        {
            if (pictureBox10.Top<5 || pictureBox10.Top>630)
            {
                pictureBox10.Visible = false;
               
                pictureBox7.Top = pictureBox10.Top;
                pictureBox7.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                Form form1 = new Form1();
                form1.Dispose();
                Form2 form2 = new Form2();
                form2.Show();
            }
            if (progressBar1.Value<=0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                Form form1 = new Form1();
                form1.Dispose();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        

        private void ballonsMove()
        {
            pictureBox2.Top = pictureBox2.Top-10 ;
            if (pictureBox2.Bottom < 0)
            {
                
                pictureBox2.Top = 900;
                pictureBox2.Left = aleatorio.Next(100, 600);
            }
            pictureBox4.Top = pictureBox4.Top -5;
            if (pictureBox4.Bottom < 0)
            {
               
                pictureBox4.Top = 900;
                pictureBox4.Left = aleatorio.Next(100, 600);
            }
            pictureBox5.Top = pictureBox5.Top - 7;
            if (pictureBox5.Bottom < 0)
            {
               
                pictureBox5.Top = 900;
                pictureBox5.Left = aleatorio.Next(100, 600);
            }
            pictureBox9.Top = pictureBox9.Top - 15;
            if (pictureBox9.Bottom < 0)
            {

                pictureBox9.Top = 900;
                pictureBox9.Left = aleatorio.Next(100, 600);
            }
            pictureBox12.Top = pictureBox12.Top - 13;
            if (pictureBox12.Bottom < 0)
            {

                pictureBox12.Top = 900;
                pictureBox12.Left = aleatorio.Next(100, 600);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox10.Top -= 50;
            pictureBox3.Top -= 50;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                pictureBox10.Top -= 25;
                pictureBox3.Top -= 25;
            }
            if (e.KeyCode== Keys.Down)
            {
                pictureBox10.Top += 25;
                pictureBox3.Top += 25;
            }
            if (e.KeyCode== Keys.Space)
            {
                pictureBox3.Visible = true;
            }
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox10.Top += 50;
            pictureBox3.Top += 50;
        }






    }
}
