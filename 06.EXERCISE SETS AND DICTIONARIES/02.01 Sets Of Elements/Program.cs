using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        SortedSet<int> setM = new SortedSet<int>();
        SortedSet<int> setN = new SortedSet<int>();
        SortedSet<int> biggerSet = new SortedSet<int>();
        SortedSet<int> smallerSet = new SortedSet<int>();

        for (int i = 0; i < input[0]; i++)
        {
            int num = int.Parse(Console.ReadLine());
            setM.Add(num);
        }
        for (int i = 0; i < input[1]; i++)
        {
            int num = int.Parse(Console.ReadLine());
            setN.Add(num);
        }
        if (setM.Count > setN.Count)
        {
            biggerSet = setM;
            smallerSet = setN;
        }
        else
        {
            biggerSet = setN;
            smallerSet = setM;
        }

        foreach (int num in biggerSet)
        {
            if (smallerSet.Contains(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}