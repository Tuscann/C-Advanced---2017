using System;
using System.Collections.Generic;
using System.Linq;
class AcademyGraduation
{
    static void Main() // 100/100
    {
        SortedDictionary<string, double[]> data = new SortedDictionary<string, double[]>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double[] scores = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            data.Add(name, scores);
        }

        foreach (KeyValuePair<string, double[]> st in data)
        {
            Console.WriteLine($"{st.Key} is graduated with {st.Value.Average()}");
        }
    }
}