using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Order(string words)
    {
        if (words == "") return words;

        var rx = new Regex("[a-zA-Z]");
        var wordsList = new List<string>(words.Split(" "));
        string[] orderedArray = new string[wordsList.Count];

        foreach (var word in wordsList)
        {
            var rep = Convert.ToInt16(rx.Replace(word, ""));
            orderedArray[rep - 1] = word;
        }
        return string.Join(" ", orderedArray);
    }
}