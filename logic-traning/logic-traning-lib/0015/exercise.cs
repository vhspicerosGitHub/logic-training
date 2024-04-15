using System.ComponentModel;
using System.Runtime.Loader;

namespace logic_traning_lib._0015
    ;
internal class exercise
{
    /// <summary>
    /// https://leetcode.com/problems/day-of-the-week/
    /// </summary>
    /// <param name="day"></param>
    /// <param name="month"></param>
    /// <param name="year"></param>
    /// <returns></returns>
    public string DayOfTheWeek(int day, int month, int year)
    {
        var d = new DateTime(year, month, day);
        return d.DayOfWeek.ToString();

    }
}