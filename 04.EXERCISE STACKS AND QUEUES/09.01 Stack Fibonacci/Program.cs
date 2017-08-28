using System;
using System.Collections.Generic;
public static class StackFibonacci
{
    static void Main() //100/100
    {
        int n = int.Parse(Console.ReadLine());
        Stack<long> stack = new Stack<long>();
        stack.Push(0);
        stack.Push(1);
        for (int i = 1; i < n; i++)
        {
            long elementInStack = stack.Pop();
            long newElement = elementInStack + stack.Peek();

            stack.Push(elementInStack);
            stack.Push(elementInStack + newElement);
        }
        Console.WriteLine(stack.Peek());
    }
}