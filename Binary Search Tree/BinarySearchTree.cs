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
        //public Node parent;
        //public Node childLeft;
        //public Node childRight;
        public List<Node> list;
        public Node[,] nodeArray; //members in list have an array position after being sorted into position




        //Ctor
        public BinarySearchTree()
        {
            list = new List<Node>();
            nodeArray = new Node[10, 10];

        }

        //methods
        //add node to list
        public void Add(Node node)
        {
            if (list.Count == 0)
            {
                root = node;
                node.isARoot = true;
                list.Add(node);
                node.xAddress = 0;
                node.yAddress = 0;
                nodeArray[0, 0] = node;

            }
            else
            {
                list.Add(node);
                Node rootCopy = root;
                DetermineParent(node, rootCopy);
                UpdateParent(node);
                AssignNodeAddress(node, node.parentNode);
                nodeArray[node.xAddress, node.yAddress] = node;

            }

        }
        public void AssignNodeAddress(Node nodeToAdd, Node nodeToCompare)
        {
            if (nodeToAdd.number > nodeToCompare.number)
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
   
        public void UpdateParent(Node node)
        {
            if(node.xAddress % 2 != 1)
            {
                nodeArray[node.parentNode.xAddress, node.parentNode.yAddress] = node;
            }
            else
            {
                nodeArray[node.parentNode.xAddress, node.parentNode.yAddress] = node;
            }
        }

        public void DetermineParent(Node node, Node comparingNode)
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
                }

            }

        }
    }
}
            
            
        
       
        

       

    

