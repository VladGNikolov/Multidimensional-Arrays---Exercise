int rowsAndCols = int.Parse(Console.ReadLine());

char[,] matrix = new char[rowsAndCols, rowsAndCols];

int[] leftCurrentIndex = new int[2];
int[] rightCurrentIndex = new int[2];
int[] leftSCurrentIndex = new int[2];
int[] rightSCurrentIndex = new int[2];
int[] leftDCurrentIndex = new int[2];
int[] rightDCurrentIndex = new int[2];
int[] leftGCurrentIndex = new int[2];
int[] rightGCurrentIndex = new int[2];
int counter = 0;

for (int i = 0; i < rowsAndCols; i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < rowsAndCols; j++)
    {
        matrix[i, j] = input[j];
    }
}

for (int row = 0; row < rowsAndCols; row++)
{
    for (int col = 0; col < rowsAndCols; col++)
    {

        if (matrix[row, col] == 'K')
        {
            leftCurrentIndex[0] = row - 1; leftCurrentIndex[1] = col - 2;
            rightCurrentIndex[0] = row + 1; rightCurrentIndex[1] = col - 2;
            leftSCurrentIndex[0] = row -1; leftSCurrentIndex[1] = col + 2;
            rightSCurrentIndex[0] = row +1; rightSCurrentIndex[1] = col + 2;
            leftDCurrentIndex[0] = row -2; leftDCurrentIndex[1] = col -1;
            rightDCurrentIndex[0] = row -2; rightDCurrentIndex[1] = col + 1;
            leftGCurrentIndex[0] =row +2; leftGCurrentIndex[1] =col -1;
            rightGCurrentIndex[0] = row +2; rightGCurrentIndex[1]=col +1;
            



            if (leftCurrentIndex[0]>=0 && leftCurrentIndex[0]<rowsAndCols 
                && leftCurrentIndex[1]>=0 && leftCurrentIndex[1]<rowsAndCols)
            {
                if (matrix[leftCurrentIndex[0], leftCurrentIndex[1]]=='K')
                {
                    matrix[leftCurrentIndex[0], leftCurrentIndex[1]] = 'O';
                    counter++;
                }
            }
            if (rightCurrentIndex[0] >= 0 && rightCurrentIndex[0] <rowsAndCols
               && rightCurrentIndex[1] >= 0 && rightCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[rightCurrentIndex[0], rightCurrentIndex[1]] == 'K')
                {
                    matrix[rightCurrentIndex[0], rightCurrentIndex[1]] = '0';
                    counter++;
                }
            }
            if (leftSCurrentIndex[0] >= 0 && leftSCurrentIndex[0] <rowsAndCols
               && leftSCurrentIndex[1] >= 0 && leftSCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[leftSCurrentIndex[0], leftSCurrentIndex[1]] == 'K')
                {
                    matrix[leftSCurrentIndex[0], leftSCurrentIndex[1]] = '0';
                    counter++;
                }
            }
            if (rightSCurrentIndex[0] >= 0 && rightSCurrentIndex[0] <rowsAndCols
             && rightSCurrentIndex[1] >= 0 && rightSCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[rightSCurrentIndex[0], rightSCurrentIndex[1]] == 'K')
                {
                    matrix[rightSCurrentIndex[0], rightSCurrentIndex[1]] = '0';
                    counter++;
                }
            }
            if (leftDCurrentIndex[0] >= 0 && leftDCurrentIndex[0] <rowsAndCols
             && leftDCurrentIndex[1] >= 0 && leftDCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[leftDCurrentIndex[0], leftDCurrentIndex[1]] == 'K')
                {
                    matrix[leftDCurrentIndex[0], leftDCurrentIndex[1]] = '0';
                    counter++;
                }
            }
            if (rightDCurrentIndex[0] >= 0 && rightDCurrentIndex[0] <rowsAndCols
             && rightDCurrentIndex[1] >= 0 && rightDCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[rightDCurrentIndex[0], rightDCurrentIndex[1]] == 'K')
                {
                    matrix[rightDCurrentIndex[0], rightDCurrentIndex[1]] = '0';
                    counter++;
                }
            }
            if (leftGCurrentIndex[0] >= 0 && leftGCurrentIndex[0] <rowsAndCols
             && leftGCurrentIndex[1] >= 0 && leftGCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[leftGCurrentIndex[0], leftGCurrentIndex[1]] == 'K')
                {
                    matrix[leftGCurrentIndex[0], leftGCurrentIndex[1]] = '0';
                    counter++;
                }
            }
            if (rightGCurrentIndex[0] >= 0 && rightGCurrentIndex[0] <rowsAndCols
             && rightGCurrentIndex[1] >= 0 && rightGCurrentIndex[1] <rowsAndCols)
            {
                if (matrix[rightGCurrentIndex[0], rightGCurrentIndex[1]] == 'K')
                {
                    matrix[rightGCurrentIndex[0], rightGCurrentIndex[1]] = '0';
                    counter++;
                }
            }

        }
    }
}
Console.WriteLine(counter);


