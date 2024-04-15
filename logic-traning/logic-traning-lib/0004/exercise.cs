using System.Numerics;

namespace logic_traning_lib._0004;
internal class exercise
{
    /// <summary>
    /// https://leetcode.com/problems/add-to-array-form-of-integer/
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var sum = BigInteger.Parse(string.Join("", num)) + k;
        var r = sum.ToString().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToList();
        return r;
    }
}
