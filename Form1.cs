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
using System.Threading;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        SoundPlayer song = new SoundPlayer(@"C:\songs\multyashnyiy-zvuk-najatiya-na-knopku-30362.wav");

        public Form1()
        {
                
                InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            
            GameCountPI gameCountPI = new GameCountPI();
            //Thread.Sleep(500);
            Hide();
            

            
            song.Play();

            gameCountPI.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            GameAssociative gameAssociative = new GameAssociative();
            
            Hide();

           // Thread.Sleep(500);
            song.Play();
            

            gameAssociative.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //TODO ПОСЛЕДНЮЮ ИГРУ
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Lesson1 lesson = new Lesson1();
            lesson.Show();
        }
    }
}
