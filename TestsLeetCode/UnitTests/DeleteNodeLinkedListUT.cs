using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class DeleteNodeLinkedListUT
{
    [TestMethod]
    public void doIt()
    {
        ListNode headNode = LLFactory.create(4, new int[] { 5, 1, 9 });
        deleteNodeLinkedListProblem.implementation(headNode.next);
        LLOperations.verify(headNode, 0, new int[] { 4, 1, 9 });

        ListNode headSecond = LLFactory.create(0, new int[] { 1 });
        deleteNodeLinkedListProblem.implementation(headSecond);
        LLOperations.verify(headSecond, 0, new int[] { 1 });

        ListNode headThird = LLFactory.create(-3, new int[] { 5, -99 });
        deleteNodeLinkedListProblem.implementation(headThird);
        LLOperations.verify(headThird, 0, new int[] { 5, -99 });
    }
}

