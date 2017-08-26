using System;
using System.Collections.Generic;

class MatchingBrackets
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Stack<int> openingIndices = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                openingIndices.Push(i);
            }
            else if (input[i] == ')')
            {
                int openingIndex = openingIndices.Pop();
                Console.WriteLine(input.Substring(openingIndex, i - openingIndex + 1));
            }
        }
    }
}