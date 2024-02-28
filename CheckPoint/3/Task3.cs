namespace CheckPoint;

public class Task3
{
    /// <summary>
    /// O(n)
    /// </summary>
    public int Linear(int[] A)
    {
        double maxIncome = 0;
        bool hasAssets = true;

        for (int i = 0; i < A.Length; i++)
        {
            if (i == 0) continue;

            if (hasAssets)
            {
                if (i == A.Length - 1)
                {
                    maxIncome += A[i];
                    break;
                }

                int previousPrice = A[i - 1];
                int price = A[i];

                if (price >= previousPrice) continue;

                maxIncome += previousPrice;
                hasAssets = false;
            }
            else
            {
                int previousPrice = A[i - 1];
                int price = A[i];

                if (price <= previousPrice) continue;

                maxIncome -= previousPrice;
                hasAssets = true;
                i--;
            }
        }

        string stringValue = maxIncome.ToString();

        // Extract the last 9 digits from the string representation
        if (stringValue.Length >= 9)
        {
            string last9Digits = stringValue.Substring(stringValue.Length - 9);
            return Convert.ToInt32(last9Digits);
        }
        else
        {
            return Convert.ToInt32(maxIncome);
        }
    }
}
