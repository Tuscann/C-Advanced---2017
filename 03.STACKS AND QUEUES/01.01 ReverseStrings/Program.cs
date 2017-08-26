using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        string str = Console.ReadLine();
        Stack<char> strStack = new Stack<char>(str);
        Console.WriteLine(string.Join("", strStack));
    }
}
