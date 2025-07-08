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
    public partial class FightForm : Form
    {
        private int barWidth = 300;
        private int barHeight = 30;
        private Rectangle targetZone;
        private int targetZoneWidth = 50;

        private int markerX = 0;
        private int markerSpeed = 6; // pixels per tick
        private bool movingRight = true;

        private Timer moveTimer;

        private Label lblInfo;

        public int DamageDealt { get; private set; } = 0;

        public FightForm()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            this.Width = 400;
            this.Height = 200;
            this.Text = "Attack Minigame";

            this.BackColor = Color.Black;

            lblInfo = new Label();
            lblInfo.ForeColor = Color.White;
            lblInfo.Font = new Font("Arial", 12, FontStyle.Bold);
            lblInfo.AutoSize = false;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Dock = DockStyle.Top;
            lblInfo.Height = 40;
            lblInfo.Text = "Press Space to attack when the red marker is in the green zone!";
            this.Controls.Add(lblInfo);

            targetZone = new Rectangle((barWidth - targetZoneWidth) / 2, 0, targetZoneWidth, barHeight);

            moveTimer = new Timer();
            moveTimer.Interval = 30;
            moveTimer.Tick += MoveTimer_Tick;
            moveTimer.Start();

            this.DoubleBuffered = true;
            this.Paint += FightForm_Paint;

            this.KeyPreview = true;
            this.KeyDown += FightForm_KeyDown;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (movingRight)
            {
                markerX += markerSpeed;
                if (markerX > barWidth)
                    movingRight = false;
            }
            else
            {
                markerX -= markerSpeed;
                if (markerX < 0)
                    movingRight = true;
            }
            this.Invalidate();
        }

        private void FightForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int barX = (this.ClientSize.Width - barWidth) / 2;
            int barY = this.ClientSize.Height / 2 - barHeight / 2;

            Rectangle barRect = new Rectangle(barX, barY, barWidth, barHeight);
            g.FillRectangle(Brushes.Gray, barRect);

            Rectangle targetRect = new Rectangle(barX + targetZone.X, barY, targetZone.Width, barHeight);
            g.FillRectangle(Brushes.Green, targetRect);

            int markerPosX = barX + markerX;
            g.DrawLine(Pens.Red, markerPosX, barY, markerPosX, barY + barHeight);
        }

        private void FightForm_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Space)
                {
                    moveTimer.Stop();

                    if (markerX >= targetZone.X && markerX <= targetZone.X + targetZone.Width)
                    {
                        DamageDealt = 100;
                        MessageBox.Show("Залиташ пиян");
                    }
                    else
                    {
                        MessageBox.Show("Изсипа са пиян");
                    }

                    // Instead of showing DodgeForm directly, do this:
                    this.Hide();  // Hide the FightForm

                    var dodgeForm = new DodgeForm();
                    dodgeForm.ShowDialog(); // Block until dodge game finishes

                    this.Close(); // Close FightForm after DodgeForm ends
                }
            }
        }
        public partial class DodgeForm : Form
        {

            private Timer gameTimer;
            private int gameDuration = 10000; // ms
            private int elapsed = 0;

            private PictureBox heart;
            private int heartSpeed = 8;

            private Rectangle block;
            private int blockSpeed = 10;
            private Random rand = new Random();

            public DodgeForm()
            {
                SetupGame();
            }

            private void SetupGame()
            {
                this.Width = 400;
                this.Height = 300;
                this.Text = "Dodge Minigame";
                this.BackColor = Color.Black;

                heart = new PictureBox();
                heart.Size = new Size(20, 20);
                heart.BackColor = Color.Red;
                heart.Location = new Point(this.ClientSize.Width / 2 - 10, this.ClientSize.Height - 40);
                this.Controls.Add(heart);

                block = new Rectangle(rand.Next(0, this.ClientSize.Width - 20), 0, 20, 20);

                gameTimer = new Timer { Interval = 30 };
                gameTimer.Tick += GameLoop;
                gameTimer.Start();

                this.DoubleBuffered = true;
                this.Paint += DodgeForm_Paint;

                this.KeyPreview = true;
                this.KeyDown += DodgeForm_KeyDown;
            }

            private void GameLoop(object s, EventArgs e)
            {
                block.Y += blockSpeed;
                if (block.Y > this.ClientSize.Height)
                {
                    block.Y = 0;
                    block.X = rand.Next(0, this.ClientSize.Width - block.Width);
                }

                Rectangle heartRect = new Rectangle(heart.Location, heart.Size);
                Rectangle blockRect = block;
                if (heartRect.IntersectsWith(blockRect))
                {
                    gameTimer.Stop();
                    MessageBox.Show("Издрайфа са пиян", "Game Over");
                    this.Close();
                    return;
                }

                elapsed += gameTimer.Interval;
                if (elapsed >= gameDuration)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Спаси са от падане и драйфане", "Victory");
                    this.Close();
                    return;
                }

                this.Invalidate();
            }

            private void DodgeForm_Paint(object sender, PaintEventArgs e)
            {
                e.Graphics.FillRectangle(Brushes.White, block);
            }

            private void DodgeForm_KeyDown(object sender, KeyEventArgs e)
            {
                var pos = heart.Location;
                if (e.KeyCode == Keys.Left && pos.X > 0) pos.X -= heartSpeed;
                if (e.KeyCode == Keys.Right && pos.X < this.ClientSize.Width - heart.Width) pos.X += heartSpeed;
                if (e.KeyCode == Keys.Up && pos.Y > 0) pos.Y -= heartSpeed;
                if (e.KeyCode == Keys.Down && pos.Y < this.ClientSize.Height - heart.Height) pos.Y += heartSpeed;

                heart.Location = pos;
            }
        }
    }
}
