using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < input.Length; i += 2)
        {
            if (i == 0)
            {
                stack.Push(int.Parse(input[i]));
            }
            else
            {
                switch (input[i - 1])
                {
                    case "-": stack.Push(stack.Pop() - int.Parse(input[i])); break;
                    case "+": stack.Push(stack.Pop() + int.Parse(input[i])); break;
                }
            }
        }
        Console.WriteLine(stack.Peek());
    }
}