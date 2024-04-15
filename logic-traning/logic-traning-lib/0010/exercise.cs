namespace logic_traning_lib._0010
    ;
internal class exercise
{

    /// <summary>
    /// https://leetcode.com/problems/numbers-with-repeated-digits/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int NumDupDigitsAtMostN(int n)
    {
        var temp = new List<int>();
        var r = 0;
        n++;
        for (int i = 10; i < n; i++)
        {
            if (hasMoreThanOneDigit(i))
            {
                temp.Add(i);
                r++;
            }
        }
        return r;
    }

    public bool hasMoreThanOneDigit(int n)
    {
        /*var dict = new Dictionary<int, int>();
        if (n < 10)
            return false;
        return foo(n, dict);*/
        if (n < 10)
            return false;

        var str = n.ToString();
        var a = str.Distinct().Count();
        return a != str.Length;
    }

    public bool foo(int n, Dictionary<int, int> dict)
    {
        if (n < 10)
            if (dict.ContainsKey(n))
                return true;
            else
                return false;

        var num = n % 10;
        if (dict.ContainsKey(num))
        {
            return true;
        }
        else
        {
            dict.Add(num, 1);
            return foo(n / 10, dict);
        }
        return false;
    }
}