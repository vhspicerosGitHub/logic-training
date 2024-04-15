//https://leetcode.com/problems/cousins-in-binary-tree/



namespace logic_traning_lib._0019;

/// <summary>
/// https://leetcode.com/problems/binary-subarrays-with-sum/
/// </summary>
public class Solution
{
    /*public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var numArrays = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            var s = nums[i];
            if (s == goal)
                numArrays++; // considering one positions is one array.
            for (int j = i; j < nums.Length - 1; j++)
            {

                s += nums[j];
                if (s == goal)
                {
                    numArrays++;
                    //break; zero case
                }

                if (s > goal)
                    break;
            }
        }
        return numArrays;
    }*/

    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        int count = 0;
        int prefixSum = 0;
        var dict = new Dictionary<int, int>();
        dict.Add(0, 1);
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            int rem = prefixSum - goal;
            if (dict.ContainsKey(rem))
            {
                count += dict[rem];
            }
            if (dict.ContainsKey(prefixSum))
            {
                dict[prefixSum]++;
            }
            else
            {
                dict.Add(prefixSum, 1);
            }
        }
        return count;
    }
}