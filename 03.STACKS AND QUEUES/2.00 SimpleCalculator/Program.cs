using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string[] input = Console.ReadLine().Split().ToArray();
        Stack<string> stack = new Stack<string>();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            stack.Push(input[i]);
        }
        int sum = 0;
        bool plusSign = true;

        for (int i = stack.Count - 1; i >= 0; i--)
        {
            stack.Reverse();
            string x = stack.Pop();

            int nnumber;
            bool truee = int.TryParse(x, out nnumber);

            if (truee)
            {
                if (plusSign)
                {
                    sum += nnumber;
                }
                else
                {
                    sum -= nnumber;
                }
            }
            else if (x == "+")
            {
                plusSign = true;
            }
            else if (x == "-")
            {
                plusSign = false;
            }
        }
        Console.WriteLine(sum);
    }
}