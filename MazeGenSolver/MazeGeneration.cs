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
        

        Node node;
        void start()
        {
            Node node = new Node();
            node.nodeCS();
        }

    }

    public class Node : MazeGeneration
    {
       public static int[][] Grid;



       public void nodeCS()
        {
       
               List<object> list = new List<object>();

               try
               {

               }
               catch (Exception e)
               {

               }


        }

    }
}
