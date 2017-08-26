using System;
using System.Collections.Generic;
class ReverseStringsDemo
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();

        Stack<char> stringStack = new Stack<char>();

        foreach (char ch in input)
        {
            stringStack.Push(ch);
        }

        Console.WriteLine(string.Join("", stringStack));
    }
}