// A Factory of LinkedList structure  
public static class LLFactory
{
  public static ListNode create(int head, int[] tail)
  {
    ListNode headNode = new ListNode(head);
    return populate(headNode, 0, tail);
  }
  private static ListNode populate(ListNode head, int cont, int[] vet)
  {
    if (cont < vet.Length)
    {
      head.next = new ListNode(vet[cont]);
      populate(head.next, cont + 1, vet);
    }
    return head;
  }
}

