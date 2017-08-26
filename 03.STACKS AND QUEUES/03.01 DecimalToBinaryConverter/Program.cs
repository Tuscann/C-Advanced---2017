using System;
using System.Collections.Generic;
class Program
{
    static void Main()  // 100/100
    {
        int value = int.Parse(Console.ReadLine());
        var stack = new Stack<int>();
        if (value == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            while (value > 0)
            {
                var remaider = value % 2;
                value = value / 2;
                stack.Push(remaider);
            }
        }
        Console.WriteLine("{0}", string.Join("", stack));
    }
}