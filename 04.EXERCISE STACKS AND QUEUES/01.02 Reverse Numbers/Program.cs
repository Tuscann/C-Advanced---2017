using System;
using System.Collections.Generic;
using System.Linq;
class ReverseNumbersWithAStack
{
    static void Main() // 100/100
    {
        IEnumerable<int> integersArr = Console.ReadLine()
            .Trim()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);
        Stack<int> integersStack = new Stack<int>(integersArr);
        Console.WriteLine(string.Join(" ", integersStack));
    }
}