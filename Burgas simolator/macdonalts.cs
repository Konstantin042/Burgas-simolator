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
    public partial class macdonalts : Form
    {
        public macdonalts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zornica zornica = new Zornica();
            zornica.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           mcdvutre mcdvutre = new mcdvutre();
            mcdvutre.Show();
            this.Close();
        }
    }
}
