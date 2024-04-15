using System;
using System.ComponentModel;
using System.Runtime.Loader;

namespace logic_traning_lib._0016
    ;
internal class exercise
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-balloons/
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public int MaxNumberOfBalloons(string text)
    {
        var magictext = "balloon";
        var count = 0;
        var cantidad = (text.Length / magictext.Length);

        foreach (var item in Enumerable.Range(0, cantidad))
        {
            var found = true;
            for (int i = 0; i < magictext.Length; i++)
            {

                var character = magictext[i].ToString();
                var index = text.IndexOf(character);
                if (index == -1)
                    found = false;
                else
                    text = text.Remove(index, 1);
            }

            if (found)
                count++;
        }



        return count;

    }
}