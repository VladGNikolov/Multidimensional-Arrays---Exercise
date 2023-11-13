int rowsAndCols = int.Parse(Console.ReadLine());

char[,] matrix = new char[rowsAndCols, rowsAndCols];
int[] currenKnight = new int[2];


for (int i = 0; i < rowsAndCols; i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < rowsAndCols; j++)
    {
        matrix[i, j] = input[j];
    }
}
int countOfKnights = 0;
int mostAttacingKnight = 0;
int currentRow = 0;
int currentCol = 0;
while (true)
{
    int attacingKnight = 0;

    for (int row = 0; row < rowsAndCols; row++)
    {
        for (int col = 0; col < rowsAndCols; col++)
        {
            if (matrix[row,col]=='K')
            {
                if (IsValid(row-1,col-2))
                {
                    if (matrix[row-1, col-2] == 'K') 
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row+1, col-2))
                {
                    if (matrix[row+1, col-2] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row-1, col+2))
                {
                    if (matrix[row -1, col+2] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row+1, col+2))
                {
                    if (matrix[row +1, col+2] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row-2, col-1))
                {
                    if (matrix[row-2, col-1] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row-2, col+1))
                {
                    if (matrix[row-2, col+1] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row+2, col-1))
                {
                    if (matrix[row+2, col-1] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (IsValid(row+2, col+1))
                {
                    if (matrix[row+2, col+1] == 'K')
                    {
                        attacingKnight++;
                    }
                }
                if (attacingKnight>mostAttacingKnight)
                {
                    mostAttacingKnight = attacingKnight;
                    currentRow = row;
                    currentCol = col;
                }
                attacingKnight = 0;
            }
        }
    }


    if (mostAttacingKnight==0)
    {
        break;
    }
    else
    {
    matrix[currentRow, currentCol] = '0';
        mostAttacingKnight=0;
        countOfKnights++;

    }
}
Console.WriteLine(countOfKnights);
bool IsValid(int row, int col) 
{
    return row >= 0 && col >= 0 && row < rowsAndCols && col < rowsAndCols;
}