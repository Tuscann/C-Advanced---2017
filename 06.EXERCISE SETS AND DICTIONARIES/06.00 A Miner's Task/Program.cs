using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        while (true)
        {
            string resource = Console.ReadLine();
            if (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!dic.ContainsKey(resource))
                {
                    dic[resource] = 0;
                }
                dic[resource] += quantity;
            }
            if (resource == "stop")
            {
                break;
            }
        }
        foreach (KeyValuePair<string, int> key in dic)
        {
            Console.WriteLine("{0} -> {1}", key.Key, key.Value);
        }
    }
}