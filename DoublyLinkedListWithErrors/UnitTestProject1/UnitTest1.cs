using DoublyLinkedListWithErrors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddToTail()
        // Tests whether adding nodes to the tail of the list works correctly
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node1); // adds node1 as the tail node
            list.addToTail(node2);
            Assert.AreEqual(node1, list.head); // checks to make sure that node1 is added as the tail node.
            Assert.AreEqual(node2, list.tail);
            Assert.AreEqual(node1.next, node2);
            Assert.AreEqual(node2.previous, node1);
        }

        [TestMethod]
        public void TestAddToHead()
        // Tests whether adding nodes to the head of the list works as expected.
        {
            DLList list = new DLList();  // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            list.addToHead(node1);
            list.addToHead(node2);
            Assert.AreEqual(node2, list.head);
            Assert.AreEqual(node1, list.tail);
            Assert.AreEqual(node2.next, node1);
            Assert.AreEqual(node1.previous, node2);
        }

        [TestMethod]
        public void testRemoveHead()
        // Tests if removing the head node from the list works properly. 
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node1);
            list.addToTail(node2);
            list.removeHead();
            Assert.AreEqual(node2, list.head); // checks to make sure node2 is the head of the list
            Assert.AreEqual(node2, list.tail); // checks to make sure that once the head is removed that node2 is now the tail
        }

        [TestMethod]
        public void testRemoveTail()
        // Tests whether removing the tail node from the list works properly.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node1);
            list.addToTail(node2);
            list.removeTail(); // removes the tail from the list
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node1, list.tail);
            Assert.IsNull(node1.next); // checks to make sure node is not null
            Assert.IsNull(node1.previous);
        }

        [TestMethod]
        public void testSearchExisting()
        // Tests whether searching for an existing node in the list works and returns the correct node.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node1);
            list.addToTail(node2);
            DLLNode result = list.search(2);
            Assert.AreEqual(node2, result);
        }

        [TestMethod]
        public void testSearchNonExisting()
        // Tests whether searching for a node that doesnt exist returns the expected value (null)
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node1);
            list.addToTail(node2);
            DLLNode result = list.search(3); // Searching for a value that doesn't exist
            Assert.IsNull(result); // checks to make sure the result is null
        }

        [TestMethod]
        public void testRemoveNode()
        // Tests if removing a node from the list works as intended.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node1);
            list.addToTail(node2);
            list.addToTail(node3);
            list.removeNode(node2); // Remove node2 from the list
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node3, list.tail);
            Assert.AreEqual(node1.next, node3);
            Assert.AreEqual(node3.previous, node1);
        }

        [TestMethod]
        public void testTotal()
        // Tests whether the total method returns the correct sum of all node values in the list.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node1);
            list.addToTail(node2);
            list.addToTail(node3);
            int total = list.total(); // calculates the list total
            Assert.AreEqual(6, total); // checks to make sure the nodes equal the correct amount
        }

        [TestMethod]
        public void testAddingPrimeNodes()
        // Tests whether adding nodes with prime numbers to the list worls correctly.
        {
            DLList list = new DLList(); // creates a new DLList

            // Add prime number nodes to the list
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);
            DLLNode node5 = new DLLNode(5);
            list.addToTail(node2);
            list.addToTail(node3); // adds nodes to the list as the tail node 
            list.addToTail(node5);
            Assert.AreEqual(node2, list.head);
            Assert.AreEqual(node5, list.tail);
            Assert.AreEqual(node2.next, node3); // verifys that node2 is the next node in the list after node3
            Assert.AreEqual(node3.next, node5);
        }

        [TestMethod]
        public void testAddingNonPrimeNodes()
        // Tests whether adding nodes with non-prime numbers to the list works as intended.
        {
            DLList list = new DLList(); // creates a new DLList

            // Add non-prime number nodes to the list
            DLLNode node4 = new DLLNode(4);
            DLLNode node6 = new DLLNode(6);
            DLLNode node8 = new DLLNode(8);
            list.addToTail(node4);
            list.addToTail(node6);
            list.addToTail(node8);
            Assert.AreEqual(node4, list.head);
            Assert.AreEqual(node8, list.tail);
            Assert.AreEqual(node4.next, node6);
            Assert.AreEqual(node6.next, node8);
        }

        [TestMethod]
        public void TestAddToTailAndHeadAlternate()
        // Tests whether adding nodes alternately to the tail and head results in the expected list structure.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node1);
            list.addToHead(node2); // adds node2 as the head node
            list.addToTail(node3); // adds node3 as the tail node 
            Assert.AreEqual(node2, list.head);
            Assert.AreEqual(node3, list.tail);
            Assert.AreEqual(node2.next, node1);
            Assert.AreEqual(node1.previous, node2); // checks that node1 is the previous node to node2
            Assert.AreEqual(node1.next, node3);
            Assert.AreEqual(node3.previous, node1);
        }

        [TestMethod]
        public void TestAddingNodesWithZeroValue()
        // Tests whether adding nodes with a value of zero to the list works correctly.
        {

            DLList list = new DLList(); //Makes a new doublylinked list 
            DLLNode node1 = new DLLNode(0);
            DLLNode node2 = new DLLNode(0);
            list.addToTail(node1);
            list.addToTail(node2);
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node2, list.tail); // checks that node2 is the tail node
            Assert.AreEqual(node1.next, node2);
            Assert.AreEqual(node2.previous, node1);

        }

        [TestMethod]
        public void TestRemoveMiddleNode()
        // // Tests whether removing a node from the middle of the list updates neighboring nodes correctly.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);
            DLLNode node4 = new DLLNode(4);
            list.addToTail(node1);
            list.addToTail(node2);
            list.addToTail(node3);
            list.addToTail(node4);
            list.removeNode(node2); // Remove node2 from the list
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node4, list.tail);
            Assert.AreEqual(node1.next, node3);
            Assert.AreEqual(node3.previous, node1);
        }

        [TestMethod]
        public void TestRemoveTailFromEmptyList()
        // // Tests whether removing the tail node from an empty list has no effect.
        {
            DLList list = new DLList(); // creates a new DLList
            list.removeTail();
            Assert.IsNull(list.head);
            Assert.IsNull(list.tail);
        }

        [TestMethod]
        public void TestAddToHeadAndRemoveHead()
        // Tests adding to head and removing from head, ensuring list remains empty.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            list.addToHead(node1);
            list.removeHead();
            Assert.IsNull(list.head);
            Assert.IsNull(list.tail);
        }

        [TestMethod]
        public void TestRemoveTailFromSingleItemList()
        // Tests removing the tail node from a list with only one node.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            list.removeTail();
            Assert.IsNull(list.head); // verifys that the head node is null
            Assert.IsNull(list.tail); // verifys that the tail node is null
        }

        [TestMethod]
        public void TestTotalWithEmptyList()
        // Tests whether the total method returns zero for an empty list.
        {
            DLList list = new DLList(); // creates a new DLList
            int total = list.total();
            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void TestAddingNegativeNodes()
        // Tests whether adding nodes with negative values to the list works correctly.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(-2);
            DLLNode node2 = new DLLNode(-4);
            list.addToTail(node1);
            list.addToTail(node2);
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node2, list.tail);
            Assert.AreEqual(node1.next, node2);
            Assert.AreEqual(node2.previous, node1);
        }

        [TestMethod]
        public void TestTotalWithSingleNode()
        // Tests whether the total method returns the correct value for a list with a single node.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(5);
            list.addToTail(node1);
            int total = list.total();
            Assert.AreEqual(5, total);
        }

        [TestMethod]
        public void TestAddingNodesWithLargeValues()
        // Tests whether adding nodes with large values to the list works correctly.
        {
            DLList list = new DLList(); // creates a new DLList
            DLLNode node1 = new DLLNode(1000);
            DLLNode node2 = new DLLNode(5000); // adds large values to the list
            list.addToTail(node1);
            list.addToTail(node2);
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node2, list.tail);
            Assert.AreEqual(node1.next, node2);
            Assert.AreEqual(node2.previous, node1);
        }
    }
}