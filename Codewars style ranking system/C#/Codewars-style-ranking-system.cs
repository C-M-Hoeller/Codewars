using System;
using System.Linq;

public class User
{
    private int[] ranks = { -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8 };
    private int curRank = 0;
    public int rank { get; set; }
    public int progress { get; set; }

    public User()
    {
        rank = ranks[curRank];
        progress = 0;
    }

    public void incProgress(int kataRank)
    {
        if (!ranks.Contains(kataRank))
        {
            throw new ArgumentException();
        }
        int kataRankIndex = Array.IndexOf(ranks, kataRank);
        if (ranks[curRank] == 8)
        {
            return;
        }
        if (curRank == kataRankIndex)
        {
            progress += 3;
        }
        else if (kataRankIndex == curRank - 1)
        {
            progress++;
        }
        else if (kataRankIndex > curRank)
        {
            int d = kataRankIndex - curRank;

            progress += 10 * d * d;
        }

        while (progress >= 100)
        {
            curRank++;
            updateRank();
            progress -= 100;
            if (ranks[curRank] == 8)
            {
                progress = 0;
                return;
            }
        }
    }

    private void updateRank()
    {
        rank = ranks[curRank];
    }
}