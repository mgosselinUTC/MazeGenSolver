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
            Node stert = new Node(1,1);
            Node.Grid[1][1] = 1;
            stert.nodeCS();
        }

    }

    public class Node : MazeGeneration
    {
        List<int> list = new List<int>();
       public static int[][] Grid;
       private int x, y;

        public Node(int x, int y)
       {
           this.x = x;
           this.y = y;
       }

       public void nodeCS()
        {
       
               List<object> list = new List<int>();
           
               try
               {
                if (Grid[x-1][y] == 0)
                {
                    list.Add(4);
                    Node node = new Node(x - 1, y);
                    
                }
                  
               }
               catch (Exception e)
               {
                  
               }

               try
               {
                   if (Grid[x][y-1] == 0)
                   {
                       list.Add(3);
                       Node node = new Node(x,y-1);
                   }

               }
           catch(Exception e)
               {

               }
           try
           {
               if(Grid[x + 1][y] == 0)
               {
                   list.Add(2);
                   Node node = new Node(x + 1, y);
               }

           }
           catch(Exception e)
           {

           }
           try
           {
               if(Grid[x][y+1] == 0)
               {
                   list.Add(1);
                   Node node = new Node(x, y + 1);
               }
           }
           catch(Exception e)
           {

           }

           Random rnd = new Random();
           int answer = rnd.Next(0, list.Count);
           switch(answer)
           {
               case 1:
                   
                   break;

               case 2:
                   break;

               case 3:

                   break;

               case 4:

                   break;


           }

        }

    }
}
