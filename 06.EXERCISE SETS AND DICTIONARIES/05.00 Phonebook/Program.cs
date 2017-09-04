using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        while (true)
        {
            string[] curent = Console.ReadLine().Split('-').ToArray();
            if (curent[0] == "search")
            {
                break;
            }
            dic[curent[0]] = curent[1];

        }
        while (true)
        {
            string curent = Console.ReadLine();
            if (curent == "stop")
            {
                break;
            }
            if (dic.ContainsKey(curent))
            {
                Console.WriteLine("{0} -> {1}", curent, dic[curent]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", curent);
            }
        }
    }
}