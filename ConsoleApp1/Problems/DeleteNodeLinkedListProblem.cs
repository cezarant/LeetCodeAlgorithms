public static class deleteNodeLinkedListProblem
{
    public static void implementation(ListNode node)
    {
        if (node.next != null)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

