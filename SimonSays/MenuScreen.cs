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
    public partial class MenuScreen : UserControl
    {
        int counter;
        public static bool isShuffle = false;

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            counter++;
 
            if (counter % 2 == 0)
            {
                shuffleButton.Visible = false;
                normalGameButton.Visible = false;
            }
            else
            {
                shuffleButton.Visible = true;
                normalGameButton.Visible = true;
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            Application.Exit();
        }

        private void normalGameButton_Click(object sender, EventArgs e)
        {
            isShuffle = false;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();

            f.Controls.Add(gs);
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            isShuffle = true;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();

            f.Controls.Add(gs);
        }
    }
}
