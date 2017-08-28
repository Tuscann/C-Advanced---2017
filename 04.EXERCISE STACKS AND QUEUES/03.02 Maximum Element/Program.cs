using System;
using System.Collections.Generic;
public static class MaxElement
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> resultStack = new Stack<int>();
        resultStack.Push(0);
        for (int i = 0; i < n; i++)
        {
            string query = Console.ReadLine();
            switch (query[0])
            {
                case '1':
                    int num = int.Parse(query.Substring(2));
                    stack.Push(num);
                    if (num > resultStack.Peek())
                    {
                        resultStack.Push(num);
                    }
                    break;
                case '2':
                    if (stack.Peek() == resultStack.Peek())
                    {
                        resultStack.Pop();
                    }
                    stack.Pop();
                    break;
                case '3':
                    Console.WriteLine(resultStack.Peek());
                    break;
            }
        }
    }
}