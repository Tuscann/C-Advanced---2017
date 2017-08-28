using System;
using System.Collections.Generic;
using System.Linq;

class BasicStackOperations
{
    static void Main() // 100/100
    {
        int[] args = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[] elementsArr = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        int elementsCount = args[0];
        int elementToPopCount = args[1];
        int element = args[2];
        
        Stack<int> elementsStack = new Stack<int>(elementsArr);

        for (int i = 0; i < elementToPopCount; i++)
        {
            elementsStack.Pop();
        }

        if (elementsStack.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (elementsStack.Contains(element))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(elementsStack.Min());
        }
    }
}