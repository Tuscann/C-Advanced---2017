using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        SortedDictionary<string, Dictionary<string, int>> dic = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string[] cuurent = Console.ReadLine().Split().ToArray();
            if (cuurent[0] == "end")
            {
                break;
            }

            string ip = cuurent[0].Substring(3, cuurent[0].Length - 3);
            string user = cuurent[2].Substring(5, cuurent[2].Length - 5);

            if (!dic.ContainsKey(user))
            {
                dic[user] = new Dictionary<string, int>();
            }
            if (!dic[user].ContainsKey(ip))
            {
                dic[user].Add(ip, 0);
            }
            dic[user][ip]++;
        }
        foreach (KeyValuePair<string, Dictionary<string, int>> user in dic)
        {
            Console.WriteLine("{0}:", user.Key);
            
            int counter = 0;

            foreach (KeyValuePair<string, int> ip in user.Value)
            {
                Console.Write("{0} => {1}", ip.Key, ip.Value);

                if (counter < user.Value.Count - 1)
                {
                    Console.Write(", ");
                    counter++;
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }
    }
}