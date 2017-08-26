using System;
using System.Collections.Generic;
using System.Linq;
class SimpleCalculator
{
    static void Main() // 100/100
    {
        string[] stringInput = Console.ReadLine().Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Reverse().ToArray();

        Stack<string> elements = new Stack<string>(stringInput);

        while (elements.Count > 2)
        {
            int result = int.Parse(elements.Pop());
            string calcOperator = elements.Pop();
            int nextNumber = int.Parse(elements.Pop());

            result += calcOperator == "+" ? nextNumber : -nextNumber; // + and - only
            elements.Push(result.ToString());
        }
        Console.WriteLine(elements.Pop());
    }
}