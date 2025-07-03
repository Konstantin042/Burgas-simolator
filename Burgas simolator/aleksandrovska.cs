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
    public partial class aleksandrovska : Form
    {
        public aleksandrovska()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 spirka1 = new Form1();
            spirka1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Centur centur = new Centur();
            centur.Show();  
            this.Hide();
        }
    }
}
