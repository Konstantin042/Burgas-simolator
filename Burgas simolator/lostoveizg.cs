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
    public partial class lostoveizg : Form
    {
        public lostoveizg()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Izgrev izgrev = new Izgrev();
            izgrev.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kofi2 kofi2 = new kofi2();
            kofi2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lostove2 lostove2 = new Lostove2();
            lostove2.Show();
            this.Close();
        }
    }
}
