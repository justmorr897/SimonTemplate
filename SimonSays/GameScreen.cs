using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;
using System.IO;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        public static int guess;

        Random randGen = new Random();

        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.mistake);

        System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();

        List<int> rotations = new List<int>();

        public GameScreen()
        {
            InitializeComponent();

            backMedia.Open(new Uri(Application.StartupPath + "/Resources/lobby-classic-game.mp3"));
            backMedia.MediaEnded += new EventHandler(backMedia_MediaEnded);

            Form1.newColors.Add(Color.Lime);
            Form1.newColors.Add(Color.Red);
            Form1.newColors.Add(Color.Blue);
            Form1.newColors.Add(Color.Yellow);

            Form1.originalColors.Add(Color.ForestGreen);
            Form1.originalColors.Add(Color.DarkRed);
            Form1.originalColors.Add(Color.DarkBlue);
            Form1.originalColors.Add(Color.Goldenrod);

            Form1.sounds.Add(greenSound);
            Form1.sounds.Add(redSound);
            Form1.sounds.Add(blueSound);
            Form1.sounds.Add(yellowSound);

            Form1.points.Add(new Point(40,37));
            Form1.points.Add(new Point(152, 37));
            Form1.points.Add(new Point(152,149));
            Form1.points.Add(new Point(40, 149));

            rotations.Add(0);
            rotations.Add(90);
            rotations.Add(0);
            rotations.Add(0);

            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(5, 5, 80, 80);
            Region buttonRegion = new Region(circlePath);
            centerLabel.Region = buttonRegion;
        }

        private void backMedia_MediaEnded(object sender, EventArgs e)
        {
            backMedia.Stop();
            backMedia.Play();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            backMedia.Play();

            Form1.pattern.Clear();
            Form1.buttons.Clear();

            if (MenuScreen.isShuffle)
            {
                Form1.buttons.Add(greenButton);
                Form1.buttons.Add(redButton);
                Form1.buttons.Add(blueButton);
                Form1.buttons.Add(yellowButton);
            }
            else
            {

            }
           
            ShuffleButtons();

            ComputerTurn();
        }


        private void ShuffleButtons()
        {
            List<Button> tempList = new List<Button>();

            while (Form1.buttons.Count > 0)
            {
                int index = randGen.Next(0, Form1.buttons.Count);

                tempList.Add(Form1.buttons[index]);
                Form1.buttons.RemoveAt(index);
            }

            Form1.buttons = tempList;

            for (int i = 0; i < Form1.buttons.Count; i++)
            {
                Form1.buttons[i].Location = Form1.points[i];
            }

            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(15, 15, 165, 169);
            Region buttonRegion = new Region(circlePath);

            Matrix transformMatrix = new Matrix();

            for (int i = 0; i < Form1.buttons.Count; i++)
            {
                transformMatrix.RotateAt(rotations[i], new PointF(55, 55));
                buttonRegion.Transform(transformMatrix);
                Form1.buttons[i].Region = buttonRegion;
            }
        }

        private void ComputerTurn()
        {
            ShuffleButtons();

            RefreshThreadSleep();

            Form1.pattern.Add(randGen.Next(0, 4));

            //0 is Green, 1 is Red, 2 is Blue, 3 is Yellow
            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.Lime;
                    greenSound.Play();
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    redSound.Play();
                }
                else if (Form1.pattern[i] == 2)
                {
                    blueButton.BackColor = Color.Blue;
                    blueSound.Play();
                }
                else
                {
                    yellowButton.BackColor = Color.Yellow;
                    yellowSound.Play();
                }

                RefreshThreadSleep();

                yellowButton.BackColor = Color.Goldenrod;
                redButton.BackColor = Color.DarkRed;
                blueButton.BackColor = Color.DarkBlue;
                greenButton.BackColor = Color.ForestGreen;

                Refresh();
                Thread.Sleep(200);
            }

            guess = 0;
            centerLabel.Text = $"{Form1.pattern.Count}";

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (Form1.pattern[guess] == Convert.ToInt16(button.Tag))
            {
                Form1.sounds[Convert.ToInt16(button.Tag)].Play();
                button.BackColor = Form1.newColors[Convert.ToInt16(button.Tag)];
                RefreshThreadSleep();
                button.BackColor = Form1.originalColors[Convert.ToInt16(button.Tag)];
                Refresh();
                guess++;
            }
            else
            {
                GameOver();
            }

            Refresh();

            if (guess == Form1.pattern.Count)
            {
                Thread.Sleep(500);
                ComputerTurn();
            }
        }

        public void GameOver()
        {
            gameOverSound.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();
            f.Controls.Add(gos);
        }

        private void RefreshThreadSleep()
        {
            Refresh();
            Thread.Sleep(500);
        }
    }
}