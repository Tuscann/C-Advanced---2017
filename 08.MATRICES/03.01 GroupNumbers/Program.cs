using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        int[][] jaggedArray = new int[3][];
        int[] arraysCurrentIndex = new int[3];

        for (int i = 0; i < numbers.Count; ++i)
        {
            int number = numbers.ElementAt(i);
            int remainder = Math.Abs(number % 3);

            switch (remainder)
            {
                case 0:
                case 1:
                case 2: arraysCurrentIndex[remainder]++; break;
                default: numbers.RemoveAt(i); i--; break;
            }
        }

        for (int i = 0; i < arraysCurrentIndex.Length; i++)
        {
            jaggedArray[i] = new int[arraysCurrentIndex[i]];
            arraysCurrentIndex[i] = 0;
        }

        foreach (int number in numbers)
        {
            int remainder = Math.Abs(number % 3);
            jaggedArray[remainder][arraysCurrentIndex[remainder]] = number;
            arraysCurrentIndex[remainder]++;
        }

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine(string.Join(" ", jaggedArray[i]));
        }
    }
}