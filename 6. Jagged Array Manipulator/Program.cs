int numOfRows = int.Parse(Console.ReadLine());

int[][] jaggedMatrix = new int[numOfRows][];

for (int row = 0; row < numOfRows; row++)
{
    int[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).ToArray();

    
        jaggedMatrix[row] = input;
    
}


for (int row = 0; row < jaggedMatrix.Length-1; row++)
{

    if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
    {
        for (int col = 0; col < jaggedMatrix[row].Length; col++)
        {

            jaggedMatrix[row][col] = jaggedMatrix[row][col] * 2;
            jaggedMatrix[row +1][col] = jaggedMatrix[row+1][col] * 2;

        }
    }
        else
        {
        for (int col = 0; col < jaggedMatrix[row].Length; col++)
        {

            jaggedMatrix[row][col] = jaggedMatrix[row][col] / 2;
        }
        for (int col = 0; col < jaggedMatrix[row + 1].Length; col++)
        {
            jaggedMatrix[row + 1][col] = jaggedMatrix[row + 1][col] / 2;
        }
    }

}


while (true)
{
    string command = Console.ReadLine();

    if (command == "End") 
    {
        break;
    }

    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    bool isValid = false;

    if (int.Parse(tokens[1])>=0 && int.Parse(tokens[1])<jaggedMatrix.Length)
    {
        if (int.Parse(tokens[2])>=0 && int.Parse(tokens[2]) < jaggedMatrix[int.Parse(tokens[1])].Length)
        {
            isValid = true;
        }
    }

    if (tokens[0]=="Add" && isValid)
    {
        jaggedMatrix[int.Parse(tokens[1])][int.Parse(tokens[2])] += int.Parse(tokens[3]);
    }
    else if (tokens[0]=="Subtract"&& isValid)
    {
        jaggedMatrix[int.Parse(tokens[1])][int.Parse(tokens[2])] -= int.Parse(tokens[3]);

    }
}
for (int i = 0; i < jaggedMatrix.Length; i++)
{
    for (int j = 0; j < jaggedMatrix[i].Length; j++)
    {
        Console.Write(jaggedMatrix[i][j] + " ");
    }
    Console.WriteLine();
}