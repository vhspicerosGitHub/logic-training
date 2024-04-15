using NUnit.Framework;

namespace logic_traning_lib._0004;

internal class exercise_test
{
    [Test]
    [TestCase(false, new int[] { 12, 15, 1, 90, 100 })]
    [TestCase(true, new int[] { 12, 15, 100, 15, 12 })]
    [TestCase(true, new int[] { 10, 10, 10 })]
    public void test1(bool exceptedResult, int[] numbers)
    {
       
    }


}
