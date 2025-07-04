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
    public partial class morksa : Form
    {
        public morksa()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            absa absa = new absa();
            absa.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bara bara = new bara();
            bara.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
