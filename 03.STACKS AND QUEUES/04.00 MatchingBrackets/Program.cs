using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == '(')
            {
                stack.Push(i);
            }
            else if (ch == ')')
            {
                int startIndex = stack.Pop();
                string contents = input.Substring(startIndex, i - startIndex + 1);
                Console.WriteLine(contents);
            }
        }
    }
}