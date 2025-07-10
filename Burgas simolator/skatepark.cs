using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burgas_simolator
{
    public partial class skatepark : Form
    {
        private int moveSpeed = 25;

        public skatepark()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Izgrev izgrev = new Izgrev();
            izgrev.Show();
            this.Close();
        }

        private void skatepark_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pictureBox1.Top -= moveSpeed;
                    break;
                case Keys.S:
                    pictureBox1.Top += moveSpeed;
                    break;
                case Keys.A:
                    pictureBox1.Left -= moveSpeed;
                    break;
                case Keys.D:
                    pictureBox1.Left += moveSpeed;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }
    }
}

