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
    public partial class skok : Form
    {
        public skok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           mosta mosta = new mosta();
           mosta.Show();    
            this.Close();
        }
    }
}
