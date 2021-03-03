using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BinarySearchTree
    {
        public Node root;
        public Node parent;
        public Node childLeft;
        public Node childRight;
        public List<Node> list;


        //Ctor
        public BinarySearchTree()
        {
            list = new List<Node>();
            //assign incoming node's parents swap these two
            //assign incoming node's root
           
        }

        //methods
        //add node to list
        public void Add(Node node)
        {
            if(list.Count == 0)
            {
                root = node;
               
            }
            list.Add(node);
        }

        //make root if none

        //identify tree location
            //foreach node in line
            //go left or right
                //if(no more down line)
                    //{decide left or right, assign number as left or right child, assign parent to child, then assign child to parent}

        //assign parent to node
            //assign childLeft or ChildRight to parent

    }
}
