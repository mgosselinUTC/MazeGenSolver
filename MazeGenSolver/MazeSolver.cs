using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenSolver
{
    public partial class MazeSolver : Form
    {
        public MazeSolver()
        {
            InitializeComponent();
        }

        private void MazeSolver_Load(object sender, EventArgs e)
        {
            //i can deal.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load maze
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                Image image = Image.FromFile(openFileDialog1.FileName);

                pictureBox1.Image = image;

            }

        }
    }

    public class PictureBoxWithInterpolationMode : PictureBox
    {
        public InterpolationMode InterpolationMode { get; set; }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.InterpolationMode = InterpolationMode;
            base.OnPaint(paintEventArgs);
        }
    }
}
