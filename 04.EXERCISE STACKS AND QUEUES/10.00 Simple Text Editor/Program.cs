using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int number = int.Parse(Console.ReadLine());
        string text = String.Empty;
        Stack<string> textVersions = new Stack<string>();

        for (int i = 0; i < number; i++)
        {
            string[] cuurennt = Console.ReadLine().Split().ToArray();

            if (cuurennt[0] == "1")
            {
                textVersions.Push(text);
                text += cuurennt[1];
            }
            else if (cuurennt[0] == "2")
            {
                textVersions.Push(text);
                int symbolsToRemove = int.Parse(cuurennt[1]);
                text = text.Substring(0, text.Length - symbolsToRemove);
            }
            else if (cuurennt[0] == "3")
            {
                int index = int.Parse(cuurennt[1]);
                Console.WriteLine(text[index - 1]);
            }
            else if (cuurennt[0] == "4")
            {
                text = textVersions.Pop();
            }
        }
    }
}