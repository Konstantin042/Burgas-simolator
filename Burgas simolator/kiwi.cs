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
        int score = 0;
        int maxBeers;
        Random rand = new Random();

        public kiwi()
        {
            InitializeComponent();
            maxBeers = rand.Next(5, 16); // Random between 5 and 15
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

        private void button3_Click(object sender, EventArgs e)
        {
            score++;
            label1.Text = $"Бири изпити: {score}";

            if (score >= maxBeers)
            {
                button3.Enabled = false;
                MessageBox.Show("Напи са мега много как ще та прибираме! Game Over.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
