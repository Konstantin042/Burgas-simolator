using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burgas_simolator
{

    public partial class kofi : Form
    {
        private int x;
        private int y;
        private List<Image> backgroundImages;
        private int imageIndex = 0;
        private const int requiredClicks = 30;
        private const int totalSeconds = 15;
        private Timer countdownTimer;
        private int secondsLeft;

        public kofi()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            x++;
            if (x % 2 == 0)
            {
                y++;
                button1.Text = y.ToString();

            }
            imageIndex = (imageIndex + 1) % backgroundImages.Count;
            this.BackgroundImage = backgroundImages[imageIndex];

            if (y >= requiredClicks)
            {
                MessageBox.Show($"Мазна направи {y} кофи за гръб.");
                this.Hide();
                Lostove lostove = new Lostove();
                lostove.Show();
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            label1.Text = $"Време: {secondsLeft}";

            if (secondsLeft <= 0)
            {
                countdownTimer.Stop();

                if (y < requiredClicks)
                {
                    countdownTimer.Stop();
                    MessageBox.Show($"Времето изтече шматка, направи {y} кофи. ТРЕНИРАЙ ПОВЕЧЕ");

                    //var lostove = new neptuna();
                    //lostove.Show();
                    //this.Close();
                }
                if (y > requiredClicks)
                {

                    MessageBox.Show($"Great! You did {y} push ups.");
                }
            }
        }

        private void kofi_Load(object sender, EventArgs e)
        {
            backgroundImages = new List<Image>
            {
                Properties.Resources.kofi1,
                Properties.Resources.kofi3,

            };
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = backgroundImages[0];

            secondsLeft = totalSeconds;


            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();


            label1.Text = $"Време: {secondsLeft}";


            button1.Text = "Бройка: 0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 0)
            {
                y++;
                button1.Text = y.ToString();

            }
            imageIndex = (imageIndex + 1) % backgroundImages.Count;
            this.BackgroundImage = backgroundImages[imageIndex];

            if (y >= requiredClicks)
            {
                countdownTimer.Stop();
                MessageBox.Show($"Мазна направи {y} кофи за гръб.");
                this.Hide();
                Lostove lostove = new Lostove();
                lostove.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            neptuna neptuna = new neptuna();
            neptuna.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            Lostove lostove1 = new Lostove();
             lostove1.Show();
             this.Close();
        }
    }
}





