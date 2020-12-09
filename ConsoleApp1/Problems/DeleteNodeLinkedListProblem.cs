public static class DeleteNodeLinkedListProblem
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public static void implementation(ListNode node)
    {        
         node.val = node.next.val;
         node.next = node.next.next;        
    }
}

