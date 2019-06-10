using System;
using System.Linq;
using System.Collections.Generic;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
      string[] splitedPhrase = phrase.Split(" ");
      List<string> jadenPhrases = new List<string>();

      for (int i = 0; i < splitedPhrase.Length; i++)
      {
        char[] chars = splitedPhrase[i].ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        jadenPhrases.Add(new string(chars));
      }

      return string.Join(" ", jadenPhrases);
    }
}