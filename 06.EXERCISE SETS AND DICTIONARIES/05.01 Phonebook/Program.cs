using System;
using System.Collections.Generic;
public class Phonebook
{
    public static void Main() // 100/100
    {
        Dictionary<string, string> phonebook = GetPhonebook();
        SearchPhonebook(phonebook);
    }

    private static void SearchPhonebook(Dictionary<string, string> phonebook)
    {
        while (true)
        {
            string name = Console.ReadLine();
            if (name == "stop") break;

            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
    }

    private static Dictionary<string, string> GetPhonebook()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "search") break;

            if (string.IsNullOrEmpty(input)) continue;

            string[] contact = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string name = contact[0];
            string phoneNumber = contact.Length > 1 ? contact[1] : null;
            phonebook[name] = phoneNumber; // add or update
        }

        return phonebook;
    }
}