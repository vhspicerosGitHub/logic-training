using System.ComponentModel;
using System.Numerics;

namespace logic_traning_lib._0005;
internal class exercise
{

    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        var sumL1 = sumNode(Reverse(l1));
        var sumL2 = sumNode(Reverse(l2));
        var sum = sumL1 + sumL2;
        var arra = sum.ToString().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
        var newNode = CreateNodeList(arra);
        return Reverse(newNode);
    }

    public string printNode(ListNode node)
    {
        var str = string.Empty;
        var current = node;
        while (current != null)
        {
            str += current.val.ToString() + "-->";
            current = current.next;
        }
        return str;
    }

    public ListNode Reverse(ListNode node)
    {
        ListNode prev = null;
        ListNode current = node;
        ListNode next = null;
        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }

    public BigInteger sumNode(ListNode node)
    {
        var current = node;
        string s = string.Empty;
        while (current != null)
        {
            s += current.val;
            current = current.next;
        }
        return BigInteger.Parse(s);
    }

    public ListNode CreateNodeList(Int32[] numbers)
    {
        var head = new ListNode();
        var current = head;
        for (int i = 0; i < numbers.Length; i++)
        {
            current.val = Convert.ToInt32(numbers[i]);
            if (i != numbers.Length - 1)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }
        return head;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
