using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burgas_simolator
{
    public partial class pulse : Form
    {
        public pulse()
        {
            InitializeComponent();
        }

        private void pulse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zornica zornica = new Zornica();
            zornica.Show();
            this.Close();
        }
    }
}
