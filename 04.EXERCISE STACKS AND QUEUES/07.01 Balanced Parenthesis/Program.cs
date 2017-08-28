using System;
using System.Collections.Generic;
using System.Linq;
public static class Parenthesis
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        bool result = true;
        foreach (char element in input)
        {
            switch (element)
            {
                case '{':
                case '[':
                case '(': stack.Push(element); break;
                case '}':
                    if (!stack.Any())
                    {
                        result = false;
                    }
                    else if (stack.Pop() != '{')
                    {
                        result = false;
                    }
                    break;
                case ')':
                    if (!stack.Any())
                    {
                        result = false;
                    }
                    else if (stack.Pop() != '(')
                    {
                        result = false;
                    }
                    break;
                case ']':
                    if (!stack.Any())
                    {
                        result = false;
                    }
                    else if (stack.Pop() != '[')
                    {
                        result = false;
                    }
                    break;
            }
            if (result == false)
            {
                break;
            }
        }
        Console.WriteLine(result ? "YES" : "NO");
    }
}