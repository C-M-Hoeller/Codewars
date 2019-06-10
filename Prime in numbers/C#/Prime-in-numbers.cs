using System;
using System.Collections.Generic;

public class PrimeDecomp
{

    public static String factors(int lst)
    {
        int divider = 1;
        var fact = new Dictionary<int, int>();

        do
        {
            divider++;
            int val = 0;

            while (lst % divider == 0)
            {
                lst /= divider;
                val++;
            }
            if (val > 0)
            {
                fact.Add(divider, val);
            }
        } while ((lst / divider != 1) && (lst % divider != 0));

        var strings = new List<string>();

        foreach (var key in fact)
        {
            if (key.Value > 1)
            {
                strings.Add($"({key.Key}**{key.Value})");
            }
            else
            {
                strings.Add($"({key.Key})");
            }
        }
        if (lst > 0)
        {
            strings.Add($"({lst})");
        }

        return string.Join("", strings);
    }
}