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
        //determines parent if greater than root
        [TestMethod]
        public void CorrectlySorts_GreaterThan_Parent()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            Node node2 = new Node(5);
            
            


            tree.Add(node1);
            tree.Add(node2);
            //node2.parent should equal node1;
            //node1.child right should = node2
            int expected = node1.number;
            int actual = node2.parentNode.number;



            //assert
            Assert.AreEqual(expected, actual);

        }
        //correctly classifies child when greater than
        [TestMethod]
        public void CorrectlySorts_GreaterThan_Child()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            Node node2 = new Node(5);




            tree.Add(node1);
            tree.Add(node2);
            //node2.parent should equal node1;
            //node1.child right should = node2
            int expected = 5;
            int actual = tree.root.childNodeRight.number;




            //assert
            Assert.AreEqual(expected, actual);

        }
        //determines parent if less than root
        [TestMethod]
        public void IfParentlessroot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            Node node2 = new Node(1);
            int expected = 3;


            tree.Add(node1);
            tree.Add(node2);
            int actual = tree.root.number;



            //assert
            Assert.AreEqual(expected, actual);

        }
        //determines parent if equal to root
        [TestMethod]
        public void BSTAsst()
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
        //does not add types other than int
        [TestMethod]
        public void BSTAssOneRoot()
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
        //correctly classifies negative numbers
        [TestMethod]
        public void signsOnlyOneRoot()
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
