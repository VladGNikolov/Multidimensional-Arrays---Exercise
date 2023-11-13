using System.Collections.Generic;

int[] rowsAndCols = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int currentPositionRow = 0;
int currentPositionCol = 0;
char[,] matrix = new char[rowsAndCols[0], rowsAndCols[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (input[col] == ' ')
        {
            continue;
        }
        else
        {
            matrix[row, col] = input[col];
            if (matrix[row, col] == 'P')
            {
                currentPositionRow = row;
                currentPositionCol = col;
            }
        }
    }
}

string tokens = Console.ReadLine();


for (int i = 0; i < tokens.Length; i++)
{
    if (tokens[i] == 'U')
    {
        if (IsValid(currentPositionRow-1, currentPositionCol))
        {
            matrix[currentPositionRow - 1, currentPositionCol] = 'P';
            matrix[currentPositionRow, currentPositionCol] = '.';
            currentPositionRow -= 1;
            
        }
        else
        {
            Console.WriteLine($"Won : {currentPositionRow} {currentPositionCol}");
            

        }
    }
    else if (tokens[i] == 'D')
    {
        if (IsValid(currentPositionRow + 1, currentPositionCol ))
        {
            matrix[currentPositionRow +1, currentPositionCol] = 'P';
            matrix[currentPositionRow, currentPositionCol] = '.';
            currentPositionRow += 1;

        }
        else
        {
            Console.WriteLine($"Won : {currentPositionRow} {currentPositionCol}");
            return;

        }
    }
    else if (tokens[i] == 'L')
    {
        if (IsValid(currentPositionRow, currentPositionCol-1))
        {
            matrix[currentPositionRow, currentPositionCol-1] = 'P';
            matrix[currentPositionRow, currentPositionCol] = '.';
            currentPositionCol -= 1;

        }
        else
        {
            Console.WriteLine($"Won : {currentPositionRow} {currentPositionCol}");
            return;

        }
    }
    else if (tokens[i] == 'R')
    {
        if (IsValid(currentPositionRow, currentPositionCol + 1))
        {
            matrix[currentPositionRow, currentPositionCol+1] = 'P';
            matrix[currentPositionRow, currentPositionCol] = '.';
            currentPositionCol += 1;

        }
        else
        {
            Console.WriteLine($"Won : {currentPositionRow} {currentPositionCol}");
            return;
        }
    }
    matrix = MethodForB();
    
    bool isTrue = false;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row, col]=='P')
            {
                isTrue= true;
                break;
            }
            
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
    if(isTrue=false)
    {
        Console.WriteLine($"Dead {currentPositionRow} {currentPositionCol}");
    }

}

char[,] MethodForB()
{
    char[,] newMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
   
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row,col]=='B')
            {
                newMatrix[row, col] = 'B';
                //up
                if (IsValid2(row-1,col))
                {
                  
                        newMatrix[row - 1, col] = 'B';
                }
                
                //down
                if (IsValid2(row +1, col))
                {
                   
                    newMatrix[row +1, col] = 'B';
                }
               
                //left
                if (IsValid2(row, col-1))
                {
                    
                   newMatrix[row, col-1] = 'B';
                }
               
                //right
                if (IsValid2(row , col+1))
                {
                    
                    newMatrix[row, col+1] = 'B';
                }
                
            }
            else
            {
                newMatrix[row, col] = '.';
            }
        }
    }
    return newMatrix;
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}


bool IsValid(int currentPositionRow, int currentPositionCol)
{
    return currentPositionRow >= 0 && currentPositionCol >= 0 && currentPositionRow < matrix.GetLength(0) && currentPositionCol < matrix.GetLength(1);
}
bool IsValid2(int row, int col)
{
    return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);

}