using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern
            lengthLabel.Text = Form1.pattern.Count.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen gs = new MenuScreen();

            f.Controls.Add(gs);
        }
    }
}
