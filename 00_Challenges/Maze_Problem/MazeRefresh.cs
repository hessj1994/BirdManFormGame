using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _00_Challenges.Maze_Problem
{
    public partial class MazeRefresh : IDontKnowWhatImDoing
    {
        public MazeRefresh()
        {
            this.BackgroundImage = global::_00_Challenges.Properties.Resources.BlankMaze;
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //set background image/color
            var colors = new[] { Color.CornflowerBlue, Color.Green, Color.Aqua, Color.Azure, Color.CadetBlue };
            var index = DateTime.Now.Second % colors.Length;
            this.BackColor = colors[index];
        }
    }
}
