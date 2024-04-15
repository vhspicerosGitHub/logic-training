using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace logic_traning_lib._0008;

internal class exercise_test
{
    [Test]
    public void test1()
    {
        int[][] puntos = new int[][]
        {
            new int[] {1, 1},
            new int[] {2, 3},
            new int[] {3, 2}
        };
        new exercise().IsBoomerang(puntos);
    }
}
