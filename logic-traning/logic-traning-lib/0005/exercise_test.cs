using logic_traning_lib._0005;
using NUnit.Framework;

namespace logic_traning_lib._0005;

internal class exercise_test
{
    [Test]
    public void test1()
    {
        var node1 = new ListNode
        {
            val = 2,
            next = new ListNode
            {
                val = 4,
                next = new ListNode { val = 3, next = null, }
            }
        };

        var node2 = new ListNode
        {
            val = 5,
            next = new ListNode
            {
                val = 6,
                next = new ListNode { val = 4, next = null, }
            }
        };

        var n = new exercise().AddTwoNumbers(node1, node2);
    }
}
