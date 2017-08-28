using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 80/100
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>(input);

        Console.WriteLine("{0}", string.Join(" ", stack));
    }
}