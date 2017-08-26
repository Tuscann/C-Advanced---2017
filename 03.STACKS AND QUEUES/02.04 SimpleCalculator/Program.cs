using System;
using System.Collections.Generic;
using System.Linq;
class SimpleCalculatorDemo
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string[] values = input.Split(' ');
        Stack<string> stack = new Stack<string>(values.Reverse());

        while (stack.Count > 1)
        {
            int first = int.Parse(stack.Pop());
            String op = stack.Pop();
            int second = int.Parse(stack.Pop());

            switch (op)
            {
                case "+":
                    stack.Push((first + second).ToString()); break;
                case "-":
                    stack.Push((first - second).ToString()); break;
            }
        }
        Console.WriteLine(stack.Pop());
    }
}