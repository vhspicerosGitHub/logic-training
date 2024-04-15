using System.ComponentModel;
using System.Numerics;
using System.Runtime.Serialization;

namespace logic_traning_lib._0007;
internal class exercise
{
    /// <summary>
    /// https://leetcode.com/problems/greatest-common-divisor-of-strings/
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public string GcdOfStrings(string str1, string str2)
    {
        //check if concatenation of two strings is the same
        if (!(str1 + str2).Equals(str2 + str1)) return "";
        //gcd of length of two string;
        int gcdlength = gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdlength);
    }
    public static int gcd(int x, int y)
    {
        if (y == 0) return x;
        else
        {
            return gcd(y, x % y);
        }
    }
}