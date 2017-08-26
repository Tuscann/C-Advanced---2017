using System;
class Program
{
    static void Main() // 100/100
    {
        var input = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(input, 2);

        Console.WriteLine(binary);
    }
}