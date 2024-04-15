using System.ComponentModel;
using System.Numerics;

namespace logic_traning_lib._0006;
internal class exercise
{

    /// <summary>
    /// https://leetcode.com/problems/sum-of-two-integers/
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetSum(int a, int b)
    {
        var l = new List<int>() { a, b };
        return l.Sum();

    }
}
