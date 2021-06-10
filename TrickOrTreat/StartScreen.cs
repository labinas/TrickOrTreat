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
    public partial class StartScreen : Form
    {
        bool currentlyAnimating = false;
        bool isAnimating = true;

        public StartScreen()
        {
            InitializeComponent();
            DoubleBuffered = true;
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


        private void playButtonClicked(object sender, EventArgs e)
        {
            Form1 game = new Form1();

            game.Width = this.Width;
            game.Height = this.Height;
            game.StartPosition = FormStartPosition.Manual;
            game.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            game.ShowDialog();
            //this.Visible = true;
        }

        private void helpButtonClicked(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen();
            helpScreen.Width = this.Width;
            helpScreen.Height = this.Height;
            helpScreen.StartPosition = FormStartPosition.Manual;
            helpScreen.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            helpScreen.ShowDialog();
            //this.Visible = true;
        }

    }
}
