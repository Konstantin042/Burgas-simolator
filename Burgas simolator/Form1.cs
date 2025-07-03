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
        private string[] dialogLines = new string[]
{
     "Герой 1: Здравей!",
     "Герой 2: Здрасти! Как си?",
     "Герой 1: Добре съм. Имаш ли време да поговорим?",
     "Герой 2: Разбира се. Какво има?",
     "Герой 1: Имам мисия за теб!"
};

        private int dialogIndex = 0;
    }
}
