namespace logic_traning_lib._0011
    ;
internal class exercise
{

    /// <summary>
    /// https://leetcode.com/problems/squares-of-a-sorted-array/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortedSquares(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
            nums[i] = nums[i] * nums[i];
        
        var l = nums.ToList();
        l.Sort();
        return l.ToArray();
    }
}