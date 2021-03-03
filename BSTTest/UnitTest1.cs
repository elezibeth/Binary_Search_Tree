using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Binary_Search_Tree;


namespace BSTTest

{
    [TestClass]
    public class UnitTest1
    {
       
        

        [TestMethod]
        public void BSTAssignsARoot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            int expected = 3;
            

            tree.Add(node1);
            int actual = tree.root.number;

            

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void BSTAssignsOnlyOneRoot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            Node node2 = new Node(5);
            int expected = 3;


            tree.Add(node1);
            tree.Add(node2);
            int actual = tree.root.number;



            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}
