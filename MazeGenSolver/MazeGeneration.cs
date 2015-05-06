using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenSolver
{
    public partial class MazeGeneration : Form
    {
        node[] cellList;
        node Cell = new node();

        public void Generate()
        {
            


        }

    }

    public class node
    {
        public int north = 1;
        public int east = 2;
        public int south = 3;
        public int west = 4;

        public bool wall = true;
        public bool marked = false;

        public void Node()
        {
            

        }


    }

    public class Grid
    {
        int gridX = 5;
        int gridY = 5;

    }



}
