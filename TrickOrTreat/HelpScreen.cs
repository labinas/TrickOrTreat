using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrickOrTreat
{
    public partial class HelpScreen : Form
    {
        bool currentlyAnimating = false;
        bool isAnimating = true;

        public HelpScreen()
        {
            InitializeComponent();
        }

        private void backButtonClicked(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Width = this.Width;
            startScreen.Height = this.Height;
            startScreen.StartPosition = FormStartPosition.Manual;
            startScreen.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            startScreen.ShowDialog();
            //this.Visible = true;
        }

        public void animationImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(this.BackgroundImage, new EventHandler(this.onFormChanged));
                currentlyAnimating = true;
            }
        }

        private void onFormChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (isAnimating)
            {
                animationImage();
                ImageAnimator.UpdateFrames();
            }
            base.OnPaintBackground(e);
        }

        private void HelpScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
