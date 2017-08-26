using System;
using System.Collections.Generic;

class ReverseStrings
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Stack<char> elements = new Stack<char>();
        foreach (var element in input)
        {
            elements.Push(element);
        }
        while (elements.Count > 0)
        {
            Console.Write(elements.Pop());
        }
        Console.WriteLine();
    }
}