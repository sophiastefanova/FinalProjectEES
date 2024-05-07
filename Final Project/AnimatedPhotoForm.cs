using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace MajorProjectEES
{
    public partial class AnimatedPhotoForm : Form
    {
        private Timer timer;
        private PictureBox pictureBox;
        private int animationStep;

        public AnimatedPhotoForm()
        {
            InitializeComponent();
            InitializePictureBox();
            InitializeTimer();
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.AnimationIMG;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(600, 400);
            pictureBox.Location = new Point((ClientSize.Width - pictureBox.Width) / 2, -pictureBox.Height);
            Controls.Add(pictureBox);
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += timer1_Tick;
            animationStep = 1;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Top < (ClientSize.Height - pictureBox.Height) / 2 - 50)
            {
                pictureBox.Top += animationStep;
                animationStep++;
            }
            else
            {
                timer.Stop();
            }
        }

       
private void AnimatedPhotoForm_Load(object sender, EventArgs e)
        {

        }

        private void start_Click_1(object sender, EventArgs e)
        {
            SignUp signWindow = new SignUp();

            signWindow.Show();
            this.Hide();
        }
    }
}
