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
    public partial class Vzr : Form
    {
        public Vzr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borisova borisova = new Borisova();
            borisova.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
