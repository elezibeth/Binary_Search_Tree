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
            if (list.Count == 0)
            {
                root = node;
                list.Add(node);
                node.yAddress = 0;
                node.yAddress = 0;

            }
            else
            {
                list.Add(node);
                //determine parent
                Node atThisPoint = root;
                Node someNode = DetermineParent(node, atThisPoint);
                //locate someNode;s address
                //node at address = someNode
                //assign node an address based on parent's address
                AssignNodeAddress(node, node.parentNode);
                //Add node to data array at index

            }

        }
        public void AssignNodeAddress(Node nodeToAdd, Node nodeToCompare)
        {
            if (nodeToAdd.number > nodeToCompare.Number)
            {
                int x = nodeToCompare.xAddress;
                nodeToAdd.xAddress = ((x + 1) * 2) - 1;
                nodeToAdd.yAddress = nodeToCompare.yAddress + 1;
            }
            if (nodeToAdd.number < nodeToCompare.number)
            {
                int x = nodeToCompare.xAddress;
                nodeToAdd.xAddress = ((x + 1) * 2) - 2;
                nodeToAdd.yAddress = nodeToCompare.yAddress + 1;
            }
            if (nodeToAdd.number == nodeToCompare.number)
            {
                if (nodeToAdd.number > 5)
                {
                    int x = nodeToCompare.xAddress;
                    nodeToAdd.xAddress = ((x + 1) * 2) - 2;
                    nodeToAdd.yAddress = nodeToCompare.yAddress + 1;
                }
                else
                {
                    int x = nodeToCompare.xAddress;
                    nodeToAdd.xAddress = ((x + 1) * 2) - 1;
                    nodeToAdd.yAddress = nodeToCompare.yAddress + 1;
                }
            }
        }

            public Node DetermineParent(Node node, Node comparingNode)
            {

                if (node.number > comparingNode.number && comparingNode.childNodeRight != null)
                {

                    comparingNode = comparingNode.childNodeRight;
                    DetermineParent(node, comparingNode);
                }
                if (node.number > comparingNode.number && comparingNode.childNodeRight == null)
                {
                    node.parentNode = comparingNode;
                    comparingNode.childNodeRight = node;
                    return comparingNode;


                }
                if (node.number < comparingNode.number && comparingNode.childNodeLeft != null)//...
                {
                    comparingNode = comparingNode.childNodeLeft;
                    DetermineParent(node, comparingNode);
                }
                if (node.number < comparingNode.number && comparingNode.childNodeLeft == null)//...
                {
                    node.parentNode = comparingNode;
                    comparingNode.childNodeLeft = node;
                    return comparingNode;

                }
            if (node.number == comparingNode.number)
            {

                if (node.number >= 5 && comparingNode.childNodeRight != null)
                {

                    comparingNode = comparingNode.childNodeRight;
                    DetermineParent(node, comparingNode);
                }
                if (node.number >= 5 && comparingNode.childNodeRight == null)
                {
                    node.parentNode = comparingNode;
                    comparingNode.childNodeRight = node;
                    return comparingNode;


                }
                if (node.number <= 5 && comparingNode.childNodeLeft != null)//...
                {
                    comparingNode = comparingNode.childNodeLeft;
                    DetermineParent(node, comparingNode);
                }
                if (node.number <= 5 && comparingNode.childNodeLeft == null)//...
                {
                    node.parentNode = comparingNode;
                    comparingNode.childNodeLeft = node;
                    return comparingNode;

                }

            }

    }
}
            
            
        
       
        

        //identify tree location
            //foreach node in line
            //go left or right
                //if(no more down line)
                    //{decide left or right, assign number as left or right child, assign parent to child, then assign child to parent}

        //assign parent to node
            //assign childLeft or ChildRight to parent

    

