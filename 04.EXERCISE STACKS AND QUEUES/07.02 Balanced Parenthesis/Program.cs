using System;
using System.Collections.Generic;
public class BalancedParentheses
{
    public static void Main() // 100/100
    {
        char[] parenthesesArr = Console.ReadLine().Trim().ToCharArray();

        if (parenthesesArr.Length % 2 != 0) // odd count of parentheses
        {
            Console.WriteLine("NO"); return;
        }

        Stack<char> parentheses = new Stack<char>();
        Dictionary<char, char> parenthesesPairs = new Dictionary<char, char>();
        parenthesesPairs['{'] = '}';
        parenthesesPairs['['] = ']';
        parenthesesPairs['('] = ')';

        foreach (char parenthesis in parenthesesArr)
        {
            if (parenthesesPairs.ContainsKey(parenthesis)) // opening paranthesis
            {
                parentheses.Push(parenthesis);
            }
            else
            {
                char openingParenthesis = parentheses.Pop();
                if (parenthesesPairs[openingParenthesis] != parenthesis) // non-matching parentheses
                {
                    Console.WriteLine("NO"); return;
                }
            }
        }
        Console.WriteLine("YES");
    }
}