int input = int.Parse(Console.ReadLine());

int[,] square = new int[input, input];
int firstDiagonal = 0;
int secondDiagonal = 0;
int current = square.GetLength(1);

for (int i = 0; i < square.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < square.GetLength(1); j++)
    {
        square[i, j] = tokens[j];

    }
    firstDiagonal += square[i, i];
    current--;
    secondDiagonal += square[i, current];

}

int sum = firstDiagonal - secondDiagonal;

Console.WriteLine(Math.Abs(sum));
