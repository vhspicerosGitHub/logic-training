
using NUnit.Framework;

namespace logic_traning_lib._0000;

internal class z_tests
{
    [Test]
    public void Matrix()
    {
        var output = PrintArray.print(3);
        Console.WriteLine(output);
    }

    [Test]
    public void BinarySearch_test()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        var key = 20;
        var found = BinarySearch.BinarySearchIterative(numbers, key);
        Console.WriteLine(found);
    }


    [Test]
    public void parentesis_test()
    {
        var text1 = "([{()}])";
        var text2 = "([])";
        var text3 = "([)]";
        var text4 = "([)";
        var r1 = new Parentesis().Valid(text1);
        var r2 = new Parentesis().Valid(text2);
        var r3 = new Parentesis().Valid(text3);
        var r4 = new Parentesis().Valid(text4);
        Assert.AreEqual(r1, true);
        Assert.AreEqual(r2, true);
        Assert.AreEqual(r3, false);
        Assert.AreEqual(r4, false);
    }

    [Test]
    public void array_diagonal_principal()
    {
        var methods = new ArrayMethods();
        var array = new ArrayMethods().createArray(10);
        methods.Diagonal_principal(array);
        Console.WriteLine(methods.print(array));
    }

    [Test]
    public void array_diagonal_invertida()
    {
        var methods = new ArrayMethods();
        var array = new ArrayMethods().createArray(10);
        methods.Diagonal_invertida(array);
        Console.WriteLine(methods.print(array));
    }

    [Test]
    public void Collatz()
    {
        var patters= new CollatzProblem().Generate(10);
        Console.WriteLine(patters);
    }

}
