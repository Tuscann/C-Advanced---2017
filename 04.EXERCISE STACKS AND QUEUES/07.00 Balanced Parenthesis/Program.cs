using System;
class Program
{
    static void Main()  // 87/100
    {
        string x = Console.ReadLine();

        int halfLenght = x.Length / 2;
        string beforeMiddle = x.Substring(0, halfLenght);
        string afterMiddle = x.Substring(halfLenght);

        string beforeReverse = String.Empty;

        for (int i = 0; i < beforeMiddle.Length; i++)
        {
            var curent = beforeMiddle[i];
            if (curent == '}')
            {
                beforeReverse += "{";
            }
            else if (curent == '{')
            {
                beforeReverse += "}";
            }
            else if (curent == '(')
            {
                beforeReverse += ")";
            }
            else if (curent == ')')
            {
                beforeReverse += "(";
            }
            else if (curent == '[')
            {
                beforeReverse += "]";
            }
            else if (curent == ']')
            {
                beforeReverse += "[";
            }
        }
        var charrArray = beforeReverse.ToCharArray();
        Array.Reverse(charrArray);
        string ivan = new string(charrArray);

        //Console.WriteLine(beforeMiddle);
        //Console.WriteLine(afterMiddle);
        //Console.WriteLine(charrArray);

        if (ivan.Equals(afterMiddle))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}