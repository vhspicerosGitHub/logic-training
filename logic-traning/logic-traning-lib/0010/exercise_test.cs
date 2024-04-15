using NUnit.Framework;

namespace logic_traning_lib._0010;

internal class exercise_test
{
    [Test]
    public void test1()
    {

        var a = new exercise().NumDupDigitsAtMostN(20);


        var e = new exercise().NumDupDigitsAtMostN(100);
        
        var b = new exercise().NumDupDigitsAtMostN(40);
        var c = new exercise().NumDupDigitsAtMostN(60);
        var d = new exercise().NumDupDigitsAtMostN(80);
        
        var f = new exercise().NumDupDigitsAtMostN(120);
        var g = new exercise().NumDupDigitsAtMostN(140);
        var h = new exercise().NumDupDigitsAtMostN(160);
        var i = new exercise().NumDupDigitsAtMostN(180);
        var j = new exercise().NumDupDigitsAtMostN(200);
        var k = new exercise().NumDupDigitsAtMostN(5987490);
    }
}
