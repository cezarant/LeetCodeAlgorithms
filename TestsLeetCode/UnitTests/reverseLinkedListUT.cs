using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class reverseLinkedListUT
{
    [TestMethod]
    public void doIt()
    {
        ListNode nodeHead = LLFactory.create(1, new int[] { 2, 3, 4, 5 });
        reverseLinkedListProblem.implementation(nodeHead);
        LLOperations.verify(nodeHead,0,new int[] { 5, 4, 3, 2, 1 }); 
    }
}
