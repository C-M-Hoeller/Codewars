using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    return str.ToLower()
      .ToCharArray()
      .GroupBy(x => x)
      .Where(y => y.Count() > 1)
      .Select(z => z.Key)
      .ToArray()
      .Count();
  }
}