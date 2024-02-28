namespace CheckPoint;

public class Task2
{
    /// <summary>
    /// O(n * log(n))
    /// </summary>
    public int LogLinear(int[] A)
    {
        Array.Sort(A); 

        var rooms = 0;
        var roommates = 0;
        var roomCapacity = 0;

        for (int i = 0; i < A.Length; i++)
        {
            var capacity = A[i];
            if (capacity == 1)
            {
                rooms++;
                continue;
            }

            if (roommates == 0)
            {
                rooms++;
                roommates++;
                roomCapacity = capacity - 1;
                continue;
            }
            else if (roomCapacity >= 1)
            {
                roommates++;
                roomCapacity--;

                if (roomCapacity == 0)
                {
                    roommates = 0;
                    roomCapacity = 0;
                }

                continue;
            }
        }

        return rooms;
    }
}
