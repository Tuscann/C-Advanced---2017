using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Dictionary<string, string> dict = new Dictionary<string, string>();
        while (input != "stop")
        {
            string email = Console.ReadLine();
            if (email.Substring(email.Length - 2, 2) != "us" && email.Substring(email.Length - 2, 2) != "uk")
            {
                dict[input] = email;
            }
            input = Console.ReadLine();
        }
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}