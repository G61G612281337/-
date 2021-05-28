using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    /// <summary>
    /// 1 уровень демо
    /// </summary>
  public   partial class GameAssociative : Form
    {

        

        public static int Counter_LVL_AssociativeGame = 1;
        public static int[] answer = new int[6];


public GameAssociative()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработки кнопок ( вынести повтор в класс обработка кнопок)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button5_Click(object sender, EventArgs e)
        {
           //todo

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            RefreshPictureBox();
            switch (Counter_LVL_AssociativeGame)
            {
                case (1):
                    answer[1] = 1;
                    break;
                case (2):
                    answer[1] = 2;
                    break;
                case (3):
                    answer[1] = 3;
                    break;
                case (4):
                    answer[1] = 4;
                    break;
                case (5):
                    answer[1] = 5;
                    break;
                case (6):
                    answer[1] = 6;
                    break;
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            RefreshPictureBox();
            switch (Counter_LVL_AssociativeGame)
            {
                case (1):
                    answer[0] = 1;
                    break;
                case (2):
                    answer[0] = 2;
                    break;
                case (3):
                    answer[0] = 3;
                    break;
                case (4):
                    answer[0] = 4;
                    break;
                case (5):
                    answer[0] = 5;
                    break;
                case (6):
                    answer[0] = 6;
                    break;
            }
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            RefreshPictureBox();
            switch (Counter_LVL_AssociativeGame)
            {
                case (1):
                    answer[2] = 1;
                    break;
                case (2):
                    answer[2] = 2;
                    break;
                case (3):
                    answer[2] = 3;
                    break;
                case (4):
                    answer[2] = 4;
                    break;
                case (5):
                    answer[2] = 5;
                    break;
                case (6):
                    answer[2] = 6;
                    break;
            }

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            RefreshPictureBox();
            switch (Counter_LVL_AssociativeGame)
            {
                case (1):
                    answer[3] = 1;
                    break;
                case (2):
                    answer[3] = 2;
                    break;
                case (3):
                    answer[3] = 3;
                    break;
                case (4):
                    answer[3] = 4;
                    break;
                case (5):
                    answer[3] = 5;
                    break;
                case (6):
                    answer[3] = 6;
                    break;
            }

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            RefreshPictureBox();
            switch (Counter_LVL_AssociativeGame)
            {
                case (1):
                    answer[4] = 1;
                    break;
                case (2):
                    answer[4] = 2;
                    break;
                case (3):
                    answer[4] = 3;
                    break;
                case (4):
                    answer[4] = 4;
                    break;
                case (5):
                    answer[4] = 5;
                    break;
                case (6):
                    answer[4] = 6;
                    break;
            }

        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            RefreshPictureBox();
            switch (Counter_LVL_AssociativeGame)
            {
                case (1):
                    answer[5] = 1;
                    break;
                case (2):
                    answer[5] = 2;
                    break;
                case (3):
                    answer[5] = 3;
                    break;
                case (4):
                    answer[5] = 4;
                    break;
                case (5):
                    answer[5] = 5;
                    break;
                case (6):
                    answer[5] = 6;
                    break;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        public void RefreshPictureBox()
        {
            if (Counter_LVL_AssociativeGame == 1)
            {
                guna2PictureBox3.Refresh();
                guna2PictureBox3.BackgroundImage = Properties.Resources.icons8_кубик_рубика_96;
                Counter_LVL_AssociativeGame += 1;
            }
            else if (Counter_LVL_AssociativeGame == 2)
            {
                guna2PictureBox3.Refresh();
                guna2PictureBox3.BackgroundImage = Properties.Resources.icons8_идея_256;

                Counter_LVL_AssociativeGame += 1;

            }
            else if (Counter_LVL_AssociativeGame == 3)
            {
                guna2PictureBox3.Refresh();
                guna2PictureBox3.BackgroundImage = Properties.Resources.icons8_карта_sd_64;

                Counter_LVL_AssociativeGame += 1;

            }
            else if (Counter_LVL_AssociativeGame == 4)
            {
                guna2PictureBox3.Refresh();
                guna2PictureBox3.BackgroundImage = Properties.Resources.icons8_огонь_144;

                Counter_LVL_AssociativeGame += 1;

            }
            else if (Counter_LVL_AssociativeGame == 5)
            {
                guna2PictureBox3.Refresh();
                guna2PictureBox3.BackgroundImage = Properties.Resources.icons8_пи_100;

                Counter_LVL_AssociativeGame += 1;
                


            }

            else if (Counter_LVL_AssociativeGame == 6)
            {
                CheckYourAnswer checkYourAnswer = new CheckYourAnswer();
                checkYourAnswer.Show();
                Hide();

            }
        }
    }
}
