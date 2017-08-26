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

        int result = elements.Count > 0 ? int.Parse(elements.Pop()) : 0;
        while (elements.Count > 1)
        {
            string calcOperator = elements.Pop();
            int nextNumber = int.Parse(elements.Pop());
            result += calcOperator == "+" ? nextNumber : -nextNumber; // + and - only
        }
        Console.WriteLine(result);
    }
}