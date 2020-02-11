namespace _00_Challenges.Maze_Problem
{
    partial class MazeUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()//form 1
        {
            this.SuspendLayout();
            // 
            // MazeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::_00_Challenges.Properties.Resources.BlankMaze;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 570);
            this.DoubleBuffered = true;
            this.Name = "MazeUI";
            this.Text = "MazeUI";
            this.ResumeLayout(false);

        }

        private void BackgroundOpacity()
        {
            Form form2 = new Form();
            form2.Text = "Test Maze";
            form2.Opacity = .75;
            form2.Size = new Size(811, 570);
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.ShowDialog();
        }

        #endregion
    }
}