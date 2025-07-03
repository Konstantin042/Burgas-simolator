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
    public partial class kiwi : Form
    {
        public kiwi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           kiwivutre kv = new kiwivutre();
            kv.Show();
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
