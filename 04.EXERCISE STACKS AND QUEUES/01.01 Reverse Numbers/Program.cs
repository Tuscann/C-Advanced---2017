using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        IEnumerable<string> number = Console.ReadLine().Split().ToArray().Reverse();

        Console.WriteLine(string.Join(" ", number));
    }
}