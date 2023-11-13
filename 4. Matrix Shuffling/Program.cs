int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[,] matrix = new string[dimensions[0], dimensions[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = input[j];

    }

}

while (true)
{
    string command = Console.ReadLine();


    if (command == "END")
    {
        break;
    }
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (tokens.Length!= 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    string com = tokens[0];
    int startRowIndex = int.Parse(tokens[1]);
    int colsStartIndex = int.Parse(tokens[2]);
    int newPositionRow = int.Parse(tokens[3]);
    int newPositionCol = int.Parse(tokens[4]);
    string currentWord = string.Empty;
    string secondCurrentWord = string.Empty;
    if(com== "swap" && startRowIndex>=0 && startRowIndex<matrix.GetLength(0) && colsStartIndex>=0 
        &&colsStartIndex< matrix.GetLength(1) && newPositionRow >= 0 && newPositionRow < matrix.GetLength(0) && newPositionCol >= 0
        && newPositionCol < matrix.GetLength(1))
    {
        currentWord = matrix[startRowIndex, colsStartIndex];
        secondCurrentWord = matrix[newPositionRow, newPositionCol];

        matrix[startRowIndex, colsStartIndex] = secondCurrentWord;
        matrix[newPositionRow, newPositionCol]= currentWord;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

}