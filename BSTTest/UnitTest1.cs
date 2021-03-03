using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Binary_Search_Tree;


namespace BSTTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void BSTAssignsARoot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            bool expected = true;

            tree.Add(node1);

            bool actual = tree.root.rootNode;

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
