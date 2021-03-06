﻿using System;
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

        private Image image;

        public MazeSolver()
        {
            InitializeComponent();
        }

        private void MazeSolver_Load(object sender, EventArgs e)
        {

            //i can deal.

            //LE TOUCAN HAS ARRIVED!!!!

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load maze
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                image = Bitmap.FromFile(openFileDialog1.FileName);

                pictureBox1.Image = image;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createGrid();
            SolveNode node = new SolveNode(1, 1);
            node.solve();
            SolveNode.printGrid();
        }

        private void createGrid()
        {
            SolveNode.grid = new string[pictureBox1.Image.Width][];

            SolveNode.endX = pictureBox1.Image.Width - 2;
            SolveNode.endY = pictureBox1.Image.Height - 2;

            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                SolveNode.grid[i] = new string[pictureBox1.Image.Height];
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    switch((uint)((Bitmap)image).GetPixel(i, j).ToArgb()) {
                        case 0xFF000000:
                            SolveNode.grid[i][j] = "wall";
                            break;
                        case 0xFFFFFFFF:
                            SolveNode.grid[i][j] = "floor";
                            break;
                    }
                    

                }
            }
        }
    }

    public class SolveNode
    {
        public static string[][] grid;
        public static int endX, endY;
        private int x, y;
        private static bool solved = false;

        public SolveNode(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void solve()
        {
            if (x == endX && y == endY)
            {
                solved = true;
                grid[x][y] = "solution";
                return;
            }

            try
            {
                if (grid[x][y + 1] == "floor")
                {
                    grid[x][y] = "potential";
                    SolveNode node = new SolveNode(x, y + 1);
                    node.solve();
                    if (solved)
                    {
                        grid[x][y] = "solution";
                        return;
                    }
                }
            }
            catch (Exception e)
            {

            }
            try
            {
                if (grid[x][y - 1] == "floor")
                {
                    grid[x][y] = "potential";
                    SolveNode node = new SolveNode(x, y - 1);
                    node.solve();
                    if (solved)
                    {
                        grid[x][y] = "solution";
                        return;
                    }
                }
            }
            catch (Exception e)
            {

            }
            try
            {
                if (grid[x + 1][y] == "floor")
                {
                    grid[x][y] = "potential";
                    SolveNode node = new SolveNode(x + 1, y);
                    node.solve();
                    if (solved)
                    {
                        grid[x][y] = "solution";
                        return;
                    }
                }
            }
            catch (Exception e)
            {

            }
            try
            {
                if (grid[x - 1][y] == "floor")
                {
                    grid[x][y] = "potential";
                    SolveNode node = new SolveNode(x - 1, y);
                    node.solve();
                    if (solved)
                    {
                        grid[x][y] = "solution";
                        return;
                    }
                }
            }
            catch (Exception e)
            {

            }
            grid[x][y] = "floor";
        }


        public static void printGrid()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {

                    Console.Write(grid[i][j] == "floor" ? "  " : (grid[i][j] == "wall" ? "OO" : (grid[i][j] == "solution" ? "**" : "XX")));

                }
                Console.WriteLine();
            }
        }
    }
}
