﻿using System;
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
    public partial class neptuna : Form
    {
        public neptuna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lostove lostove = new Lostove();
            lostove.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            morksa morksa = new morksa();
            morksa.Show();
            this.Close();
        }
    }
}
