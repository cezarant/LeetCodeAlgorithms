

public static class bestTimeToBuyProblem
{
    public static int implementation(int[] prices)
    {
        int i = 0;
        int j = 1;
        int maxProfit = 0;

        if ((prices.Length == 0) || (prices.Length == 1))
            return 0;
        do
        {
            do
            {
                if (prices[i] < prices[j])
                    if ((prices[j] - prices[i]) > maxProfit)
                        maxProfit = prices[j] - prices[i];

                j++;
            } while (j < prices.Length);
            j = i + 1;
            i++;
        } while (i < prices.Length - 1);

        return maxProfit;
    }
}

