namespace logic_traning_lib._0013
    ;
internal class exercise
{
    /// <summary>
    /// https://leetcode.com/problems/duplicate-zeros/
    /// </summary>
    /// <param name="arr"></param>
    public void DuplicateZeros(int[] arr)
    {
        if (!arr.Contains(0))
            return;
        var s = string.Join(string.Empty, arr);
        s = s.Replace("0", "00");
        var n = s.ToCharArray().Select(x => Convert.ToInt32(x.ToString()));
        var narray = n.ToList().GetRange(0, arr.Length).ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = narray[i];
        }

    }
}