using NUnit.Framework;

namespace logic_traning_lib._0002;

internal class exercise_test
{
    [Test]
    [TestCase(new int[] { 100 }, new int[] { 12, 15, 1, 90, 100 }, 1)]
    [TestCase(new int[] { 100 ,90}, new int[] { 12, 15, 1, 90, 100 }, 2)]
    public void test1(int[] exceptedResult, int[] numbers, int maxcount)
    {
        Assert.That(exceptedResult, Is.EqualTo(exercise.GetMaxs(numbers, maxcount)));
    }


}
