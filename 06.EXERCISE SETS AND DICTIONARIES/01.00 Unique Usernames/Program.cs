using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        HashSet<string> set = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string curentUsername = Console.ReadLine();
            set.Add(curentUsername);
        }
        foreach (string username in set)
        {
            Console.WriteLine(username);
        }
    }
}