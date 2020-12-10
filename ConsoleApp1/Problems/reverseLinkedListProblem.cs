public static class reverseLinkedListProblem
{
    public static void implementation(ListNode nodeHead)
    {
        ListNode prev = null;
        ListNode curr = nodeHead;        
        while (curr != null){
            ListNode nextNode = curr.next;
            nextNode.next = prev; 
            prev = 
        }
    }    
}

