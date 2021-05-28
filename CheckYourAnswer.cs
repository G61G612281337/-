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
    public partial class CheckYourAnswer : Form
    {
        public CheckYourAnswer()
        {
            InitializeComponent();

            if (n1.SelectedIndex == 4)
            {
                MessageBox.Show("fds");
            }

        }


        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (n1.SelectedIndex == GameAssociative.answer[0] - 1 ||
                n2.SelectedIndex == GameAssociative.answer[1] - 1 ||
                n3.SelectedIndex == GameAssociative.answer[2] - 1 ||
                n4.SelectedIndex == GameAssociative.answer[3] - 1 ||
                n5.SelectedIndex == GameAssociative.answer[4] - 1 ||
                n6.SelectedIndex == GameAssociative.answer[5] - 1 )
            {
                ConpAssociative conpAssociative = new ConpAssociative();
                conpAssociative.Show();


            }


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
