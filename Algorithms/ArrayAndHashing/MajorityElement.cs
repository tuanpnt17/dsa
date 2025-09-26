namespace Algorithms.ArrayAndHashing;

public class MajorityElement
{
    public static int ApproachOne(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }

    public static int ApproachTwo(int[] nums)
    {
        var counts = new Dictionary<int, int>();
        int majorityCount = nums.Length / 2;
        foreach (int num in nums)
        {
            if (counts.TryGetValue(num, out int value))
            {
                counts[num] = ++value;
            }
            else
            {
                counts[num] = 1;
            }
            if (counts[num] > majorityCount)
            {
                return num;
            }
        }

        return -1; // This line should never be reached if input is valid
    }


}
