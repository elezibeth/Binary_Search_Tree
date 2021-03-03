using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        public int number;
        public Node childNodeLeft;
        public Node childNodeRight;
        public Node parentNode;
        public Node rootNode;
        public int xAddress;
        public int yAddress;
        public bool isARoot;
        
        

        public Node(int number)
        {
            this.number = number;
            
        }

        //methods

     
        //assign parent
        //assign children left or right
    }
}
