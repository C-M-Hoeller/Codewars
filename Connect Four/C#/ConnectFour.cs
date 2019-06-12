using System;
using System.Collections.Generic;
using System.Linq;

public class ConnectFour
{
    public static string WhoIsWinner(List<string> piecesPositionList)
    {
        var table = new int[7, 6];
        int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0;
        string[] winnerColor = { "Draw", "Red", "Yellow" };

        foreach (var piece in piecesPositionList)
        {
            var color = piece.Split("_")[1];
            switch (piece.First())
            {
                case 'A': if (color == "Red") table[0, a] = 1; else if (color == "Yellow") table[0, a] = 2; a++; break; // Fills the Array
                case 'B': if (color == "Red") table[1, b] = 1; else if (color == "Yellow") table[1, b] = 2; b++; break;
                case 'C': if (color == "Red") table[2, c] = 1; else if (color == "Yellow") table[2, c] = 2; c++; break;
                case 'D': if (color == "Red") table[3, d] = 1; else if (color == "Yellow") table[3, d] = 2; d++; break;
                case 'E': if (color == "Red") table[4, e] = 1; else if (color == "Yellow") table[4, e] = 2; e++; break;
                case 'F': if (color == "Red") table[5, f] = 1; else if (color == "Yellow") table[5, f] = 2; f++; break;
                case 'G': if (color == "Red") table[6, g] = 1; else if (color == "Yellow") table[6, g] = 2; g++; break;
            }

            var winner = IsWinner(table);
            if (winner != 0)
            {
                return winnerColor[winner];
            }
        }
        return winnerColor[0];
    }


    private static int IsWinner(int[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (table[i, j] != 0)
                {
                    if (j < 3 && table[i, j] == table[i, j + 1] && table[i, j] == table[i, j + 2] && table[i, j] == table[i, j + 3])
                    {
                        return table[i, j];
                    }
                    else if (i < 4 && table[i, j] == table[i + 1, j] && table[i, j] == table[i + 2, j] && table[i, j] == table[i + 3, j])
                    {
                        return table[i, j];
                    }
                    else if (i < 4 && j < 3 && table[i, j] == table[i + 1, j + 1] && table[i, j] == table[i + 2, j + 2] && table[i, j] == table[i + 3, j + 3])
                    {
                        return table[i, j];
                    }
                    else if (i > 3 && j < 3 && table[i, j] == table[i - 1, j + 1] && table[i, j] == table[i - 2, j + 2] && table[i, j] == table[i - 3, j + 3])
                    {
                        return table[i, j];
                    }
                }
                else
                    break;
            }
        }
        return 0;
    }
}