using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class GameCountPI : Form
    {
        public string[] levl = new string[] { "3,1", "3,14", "3,141" };
        public int counter_lvl = 1;
        SoundPlayer song = new SoundPlayer(@"C:\songs\multyashnyiy-zvuk-najatiya-na-knopku-30362.wav");


        public GameCountPI()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (counter_lvl == 1)
            {
                StartGameLVLFIRST();
                counter_lvl += 1;
            }
           else if (counter_lvl == 2)
            {
                StartGameLVLSECOND();
                counter_lvl += 1;
            }
            else if (counter_lvl == 3)
            {
                StartGameLVLTHR();
                counter_lvl += 1;
            }

        }

        public void StartGameLVLFIRST() {
            label1.Text = levl[0];
            timer1.Start();
            guna2Button1.Enabled = false;
        }
        public void StartGameLVLSECOND()
        {
            label1.Text = levl[1];
            timer2.Start();
            guna2Button1.Enabled = false;

        }
        public void StartGameLVLTHR()
        {
            label1.Text = levl[2];
            timer3.Start();
            guna2Button1.Enabled = false;

        }

        public void Check() 
        {
            if (guna2TextBox1.Text == levl[0])
            {
                Complited complited = new Complited();
                
                complited.Show();

                guna2TextBox1.Clear();
            }
           else if (guna2TextBox1.Text == levl[1])
            {
                Complited complited = new Complited();

                complited.Show();

                guna2TextBox1.Clear();

            }
            else if (guna2TextBox1.Text == levl[2])
            {
                Complited complited = new Complited();

                complited.Show();

                guna2TextBox1.Clear();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            song.Play();
            
            Check();
            guna2Button1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            song.Play();
            Thread.Sleep(200);
            Form1 form = new Form1();
            form.Show();
            Hide();
         

        }
    }
}
