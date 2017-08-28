using System;
using System.Collections.Generic;
using System.Linq;
public static class BsicStackOperations
{
    static void Main() // 100/100
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>();
        int N = nums[0];
        int S = nums[1];
        int X = nums[2];
        for (int i = 0; i < N; i++)
            stack.Push(arr[i]);
        for (int i = 0; i < S; i++)
            stack.Pop();
        if (stack.Contains(X))
            Console.WriteLine("true");
        else if (stack.Count == 0)
            Console.WriteLine("0");
        else
            Console.WriteLine(stack.ToArray().Min());
    }
}