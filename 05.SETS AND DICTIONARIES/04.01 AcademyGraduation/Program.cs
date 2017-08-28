using System;
using System.Collections.Generic;
using System.Linq;

public static class AcademyGraduation
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        var dict = new SortedDictionary<string, double>();
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double[] grades = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double avgScore = 0;
            for (int q = 0; q < grades.Length; q++)
            {
                avgScore += grades[q];
            }
            dict[name] = avgScore / grades.Length;
        }
        foreach (var student in dict)
        {
            Console.WriteLine($"{student.Key} is graduated with {student.Value}");
        }
    }
}