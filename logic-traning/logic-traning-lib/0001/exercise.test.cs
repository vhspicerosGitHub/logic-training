using NUnit.Framework;

namespace logic_traning_lib._0001;

internal class exercise_test
{
    [Test]
    [TestCase(100, new int[] { 12, 15, 1, 90, 100 })]
    [TestCase(90, new int[] { 90 })]
    [TestCase(120, new int[] { 80,90,100,120,80 })]
    public void test1(int exceptedResult,  int[] numbers)
    {
        Assert.That(exceptedResult, Is.EqualTo(exercise.GetMax(numbers)));
    }


}
