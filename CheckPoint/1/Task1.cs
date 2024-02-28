namespace CheckPoint;

public class Task1
{
    /// <summary>
    ///  O(n)
    /// </summary>
    public int Linear(int[] D, int[] C, int P)
    {
        int n = D.Length;
        int totalFulfilled = 0;
        long totalDelivered = 0;

        for (int i = 0; i < n; i++)
        {
            if (D[i] <= totalDelivered + 1 && totalDelivered + C[i] <= P)
            {
                // If can be fulfilled then deliver
                totalDelivered += C[i];
                totalFulfilled++;
            }
        }

        return totalFulfilled;
    }
}
