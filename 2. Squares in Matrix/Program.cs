using System;
using System.Linq;

int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

char[,] matrix = new char[input[0], input[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{

    char[] chars = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = chars[j];
    }
}
int counter = 0;
for (int l = 1; l < matrix.GetLength(0); l++)
{
    for (int m = 1; m < matrix.GetLength(1); m++)
    {
        char currentLetter = matrix[l - 1, m - 1];
        if (currentLetter == matrix[l - 1, m] && currentLetter == matrix[l, m - 1] && currentLetter == matrix[l,m])
        {
            counter++;
        }
    }
}

Console.WriteLine(counter);