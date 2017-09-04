using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 40/100
    {
        var input = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var dic = new Dictionary<int, List<int>>();
        dic[0] = new List<int>();
        dic[1] = new List<int>();
        dic[2] = new List<int>();

        foreach (var number in input)
        {
            if (Math.Abs(number) % 3 == 0)
            {
                dic[0].Add(number);
            }
            if (Math.Abs(number) % 3 == 1)
            {
                dic[1].Add(number);
            }
            if (Math.Abs(number) % 3 == 2)
            {
                dic[2].Add(number);
            }
        }
        foreach (var row in dic)
        {
            Console.WriteLine(string.Join(" ", row.Value));
        }
    }
}