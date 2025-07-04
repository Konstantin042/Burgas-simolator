using Burgas_simolator.Properties;
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
    public partial class kiwivutre : Form
    {
        int count = 0;

        public kiwivutre()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 2)
            {
                this.BackgroundImage = Resources.Toshko1;
                label1.Text = "Ко стаа маняци3";
                count++;
            }
            if (count == 1)
            {
                this.BackgroundImage = Resources.toshko2;
                label1.Text = "Как си? по една бира ли ще пиеш тук за компания.";
                count++;
            }
            if(count == 0)
            {
                this.BackgroundImage = Resources.toshko3;
                label1.Text = "Ко стаа маняци!";
                count++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kiwi kiwi = new kiwi();
            kiwi.Show();
            this.Hide();

        }

        private void kiwivutre_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
