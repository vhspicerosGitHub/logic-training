using logic_traning_lib._0005;
using NUnit.Framework;

namespace logic_traning_lib._0007;

internal class exercise_test
{
    [Test]
    public void test1()
    {
       var a = new exercise().GcdOfStrings("ABCABC", "ABC");
        Assert.AreEqual("ABC", a);
    }

    [Test]
    public void test3()
    {
        var a = new exercise().GcdOfStrings("ABABAB", "ABAB");
        Assert.AreEqual("AB", a);
    }
}
