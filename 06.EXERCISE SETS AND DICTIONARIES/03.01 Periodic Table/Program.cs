using System;
using System.Collections.Generic;
using System.Linq;
class PeriodicTable
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> elements = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] compounds = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string ele in compounds)
            {
                if (!elements.Contains(ele))
                {
                    elements.Add(ele);
                }
            }
        }
        Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
    }
}