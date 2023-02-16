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

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //TODO: create a List to store the pattern. Must be accessable on other screens
        public static List<int> pattern = new List<int>();
        public static List<Point> points = new List<Point>();
        public static List<Button> buttons = new List<Button>();
        public static List<Button> tempList = new List<Button>();
        public static List<Color> newColors = new List<Color>();
        public static List<Color> originalColors = new List<Color>();

        public static List<SoundPlayer> sounds = new List<SoundPlayer>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Launch MenuScreen
            MenuScreen ms = new MenuScreen();

            this.Controls.Add(ms);
        }
    }
}
