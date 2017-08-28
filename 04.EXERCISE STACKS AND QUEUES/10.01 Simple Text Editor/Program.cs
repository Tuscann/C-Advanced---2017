using System;
using System.Collections.Generic;
using System.Text;
public static class SimpleTextEditor
{
    static void Main() // 100/100
    {
        int lines = int.Parse(Console.ReadLine());

        Stack<string> stack = new Stack<string>();
        StringBuilder stringBuild = new StringBuilder();

        while (lines-- > 0)
        {
            string[] inputParams = Console.ReadLine().Split();
            string command = inputParams[0];
            string value = inputParams.Length > 1 ? inputParams[1] : null;

            switch (command)
            {
                case "1":
                    stack.Push(stringBuild.ToString());
                    stringBuild.Append(value);
                    break;
                case "2":
                    stack.Push(stringBuild.ToString());
                    stringBuild.Length -= int.Parse(value);
                    break;
                case "3":
                    Console.WriteLine(stringBuild[int.Parse(value) - 1]);
                    break;
                case "4":
                    stringBuild = new StringBuilder(stack.Pop());
                    break;
            }
        }
    }
}