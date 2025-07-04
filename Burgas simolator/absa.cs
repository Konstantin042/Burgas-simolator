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
    public partial class absa : Form
    {
        public absa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            absa_vutre absa_ = new absa_vutre();
            absa_.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           morksa morksa = new morksa();
            morksa.Show();
            this.Hide();
        }
    }
}
