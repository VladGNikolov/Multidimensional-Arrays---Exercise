int[] dimention = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string input = Console.ReadLine();
int Lenght = input.Length;
int currentLenght = 0;
char a;

char[,] matrix = new char[dimention[0], dimention[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i%2 ==0)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            if (currentLenght<Lenght)
            {
                a = input[currentLenght];
                matrix[i, j] = a;
                currentLenght++;
            }
            else
            {
                currentLenght = 0;

                a = input[currentLenght];
                matrix[i, j] = a;
                currentLenght++;
            }
    }
    }
    else
    {
        for(int j = matrix.GetLength(1)-1; j >=0 ; j--)
        {
            if (currentLenght < Lenght)
            {
                a = input[currentLenght];
                matrix[i, j] = a;
                currentLenght++;
            }
            else
            {
                currentLenght = 0;
                a = input[currentLenght];
                matrix[i, j] = a;
                currentLenght++;

            }
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]);
    }
    Console.WriteLine();
}