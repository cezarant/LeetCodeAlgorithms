using FluentAssertions;


public static class LLOperations
{
    public static void verify(ListNode nodeHead, int cont, int[] arrExpected)
    {
        if (nodeHead.next != null)
        {
            nodeHead.val.Should().Be(arrExpected[cont]);
            verify(nodeHead.next, (cont + 1), arrExpected);
        }
    }
}

