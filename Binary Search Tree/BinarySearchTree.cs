﻿using System;
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
        public Node[,] nodeArray;




        //Ctor
        public BinarySearchTree()
        {
            list = new List<Node>();
            //assign incoming node's parents swap these two
            //assign incoming node's root
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
                //determine parent
                Node atThisPoint = root;
                DetermineParent(node, atThisPoint);
                //locate parent Node;s address
                //update with new child
                UpdateParent(node);
                //assign node an address based on parent's address
                AssignNodeAddress(node, node.parentNode);
                //Add node to data array at index
                AddNodeToArray(node);

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
        public void AddNodeToArray(Node node)
        {
            int x = node.xAddress;
            int y = node.yAddress;
            nodeArray[x, y] = node;
        }
        public void UpdateParent(Node node)
        {
            
            int evenOdd = node.xAddress % 2;
            if(evenOdd != 1)
            {
                int x = node.parentNode.xAddress;
                int y = node.parentNode.yAddress;
                nodeArray[x, y].childNodeLeft = node;
            }
            else
            {
                int x = node.parentNode.xAddress;
                int y = node.parentNode.yAddress;
                nodeArray[x, y].childNodeRight = node;
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
            
            
        
       
        

        //identify tree location
            //foreach node in line
            //go left or right
                //if(no more down line)
                    //{decide left or right, assign number as left or right child, assign parent to child, then assign child to parent}

        //assign parent to node
            //assign childLeft or ChildRight to parent

    

