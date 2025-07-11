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
    public partial class kfcvutre : Form
    {
        public kfcvutre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kfc kfc = new Kfc();
            kfc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
