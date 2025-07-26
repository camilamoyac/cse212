using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue should return item with highest priority
    // Expected Result: "high"
    // Defect(s) Found: medium is returned instead of high, so priority dequeue is wrong.
    public void Test_Dequeue_HighestPriorityItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5);
        priorityQueue.Enqueue("high", 10);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Items with same priority are dequeued in FIFO order
    // Expected Result: "firstHigh" then "secondHigh"
    // Defect(s) Found: secondHigh is returned instead of firstHigh, so fifo order might be incorrectly implemented
    public void Test_Dequeue_FifoTieBreaker()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("firstHigh", 10);
        priorityQueue.Enqueue("secondHigh", 10);
        priorityQueue.Enqueue("low", 1);

        Assert.AreEqual("firstHigh", priorityQueue.Dequeue());
        Assert.AreEqual("secondHigh", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue
    // Expected Result: InvalidOperationException with "The queue is empty."
    // Defect(s) Found: no defects found
    public void Test_Dequeue_EmptyQueue_Throws()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty.");
    }

    [TestMethod]
    // Scenario: Enqueue maintains insertion order
    // Expected Result: "[apple (Pri:2), banana (Pri:3)]"
    // Defect(s) Found: no defects found
    public void Test_ToString_Format()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("apple", 2);
        priorityQueue.Enqueue("banana", 3);
        string expected = "[apple (Pri:2), banana (Pri:3)]";
        Assert.AreEqual(expected, priorityQueue.ToString());
    }
}