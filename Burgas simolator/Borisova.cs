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
    public partial class Borisova : Form
    {
        public Borisova()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Vzr vzr = new Vzr(); 
            vzr.Show();
            this.Close();
        }
    }
}
