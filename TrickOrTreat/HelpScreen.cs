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
    }
}
