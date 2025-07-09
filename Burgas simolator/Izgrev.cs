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
    public partial class Izgrev : Form
    {
        public Izgrev()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skatepark skatepark1 = new skatepark();
            skatepark1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TerminalIzg terminalIzg = new TerminalIzg();
            terminalIzg.Show();
            this.Close();
        }
    }
}
