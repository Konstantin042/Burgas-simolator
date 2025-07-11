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
    public partial class Mol : Form
    {
        public Mol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slaveilov slaveilov = new Slaveilov();
            slaveilov.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mol1 mol1 = new mol1();
            mol1.Show();
            this.Close();
        }
    }
}
