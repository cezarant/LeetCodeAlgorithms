using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DeleteNodeLinkedListProblem;
using FluentAssertions;

namespace TestsLeetCode
{
    [TestClass]
    public class DeleteNodeLinkedListUT
    {
        [TestMethod]
        public void doIt()
        {
            ListNode headNode =new ListNode(4);                  
            populateNodes(headNode, 0, new int[] { 5, 1, 9 });            
            DeleteNodeLinkedListProblem.implementation(headNode.next);
            verify(headNode,new int[] {4, 1, 9 },0);

            ListNode headSecond = new ListNode(0);
            populateNodes(headSecond, 0, new int[] { 1});
            DeleteNodeLinkedListProblem.implementation(headSecond);
            verify(headSecond, new int[] {1}, 0);

            ListNode headThird = new ListNode(-3);
            populateNodes(headThird, 0, new int[] { 5,-99 });
            DeleteNodeLinkedListProblem.implementation(headThird);
            verify(headThird, new int[] { 5,-99 }, 0);
        }
        private ListNode populateNodes(ListNode head,int cont,int[] vet){
            if (cont < vet.Length)
            {
                head.next = new ListNode(vet[cont]);
                populateNodes(head.next, cont + 1, vet);
            }            
            return head;             
        } 
        private void verify(ListNode nodeHead,int[] arrExpected,int cont){
            if (nodeHead.next != null)
            {
                nodeHead.val.Should().Be(arrExpected[cont]);
                verify(nodeHead.next, arrExpected, (cont + 1));
            }            
        }
    }
}
