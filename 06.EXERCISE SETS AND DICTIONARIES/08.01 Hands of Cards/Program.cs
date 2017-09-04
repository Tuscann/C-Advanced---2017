using System;
using System.Collections.Generic;

class HandsOfCards
{
    private static string[] cards;
    private static string[] multiplier;

    static void Main() // 100/100
    {
        string input = string.Empty;
        Dictionary<string, HashSet<string>> people = new Dictionary<string, HashSet<string>>();

        cards = new [] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        multiplier = new [] { "C", "D", "H", "S" };

        while ((input = Console.ReadLine()) != "JOKER")
        {
            string[] tokens = input.Split(':');
            string player = tokens[0];
            string[] playerCards = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (people.ContainsKey(player))
            {
                people[player].UnionWith(playerCards);
            }
            else
            {
                people.Add(player, new HashSet<string>(playerCards));
            }
        }

        foreach (string player in people.Keys)
        {
            int playerScore = CalculateScore(people[player]);
            Console.WriteLine($"{player}: {playerScore}");
        }
    }

    private static int CalculateScore(HashSet<string> playerCards)
    {
        int cardsScore = 0;

        foreach (string card in playerCards)
        {
            int tempScore = (Array.IndexOf(cards, card.Remove(card.Length - 1)) + 2) *
                (Array.IndexOf(multiplier, card[card.Length - 1].ToString()) + 1);
            cardsScore += tempScore;
        }

        return cardsScore;
    }
}