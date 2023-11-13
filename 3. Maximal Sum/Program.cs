int[] dimentions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

static int square(int[,] matrix, int i, int j)
{
    return matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
}

int[,] matrix = new int[dimentions[0], dimentions[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j];
    }
}
int currentSum = 0;
int sum = int.MinValue;
int[] startCurrentIndex = new int[2];
for (int i = 0; i < matrix.GetLength(0) - 2; i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 2; j++)
    {
        currentSum = square(matrix, i, j);

        if (currentSum > sum)
        {
            sum = currentSum;
            startCurrentIndex[0] = i; startCurrentIndex[1] = j;
        }
    }
}
Console.WriteLine($"Sum = {sum}");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {

        Console.Write(matrix[startCurrentIndex[0] + i, startCurrentIndex[1] + j] + " ");
    }
    Console.WriteLine();
}
