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
    public partial class Centur : Form
    {
        public Centur()
        {
            InitializeComponent();
        }

        private void Centur_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 spirka = new Form1();
            spirka.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            gara_ug g = new gara_ug();
            g.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            alosha alosha = new alosha();
            alosha.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aleksandrovska a = new aleksandrovska();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiwi k = new kiwi();
            k.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            morksa m = new morksa();
            m.Show();
            this.Hide();
        }
    }
}
