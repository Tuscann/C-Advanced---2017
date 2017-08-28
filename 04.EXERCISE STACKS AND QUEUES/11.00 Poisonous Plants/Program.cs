using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._00_Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int pestizidePower = int.Parse(Console.ReadLine());

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                dic.Add(i + 1, array[i]);
            }
            int counter = 0;
            for (int i = 1; i <= array.Length; i++)
            {
                if (i <= array.Length - 1)
                {
                    int curentPestiside = dic[i];
                    int nextPestiside = dic[i + 1];
                    if (curentPestiside < nextPestiside)
                    {
                        Console.WriteLine(dic[i]);
                        dic[i] = 0;

                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);



        }
    }
}
