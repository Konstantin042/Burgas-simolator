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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Centur centur = new Centur();
            centur.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            morksa morksa = new morksa();
            morksa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Izgrev izgrev = new Izgrev();
            izgrev.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Zornica zornica = new Zornica();
            zornica.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Slaveilov slaveilov = new Slaveilov();
            slaveilov.Show();
            this.Hide();

        }
    }
}
