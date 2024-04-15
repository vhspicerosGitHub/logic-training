using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_traning_lib._0000
{
    internal static class PrintArray
    {
        public static string print(int n)
        {
            var r = "";
            var a = new int[n, n];
            var counter = 1;
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    r += $"_{counter}_";
                    counter++;
                }

                r += Environment.NewLine;
            }
            return r;
        }

    }
}
