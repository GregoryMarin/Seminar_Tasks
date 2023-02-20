
int[,] CreateMatrixNM(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

// Печать массива int
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + ", ");
            else Console.Write(matrix[i, j]);
        }
        Console.WriteLine("]");
    }
}

void SquareMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j]*=matrix[i,j];
        }
    }
}

int[,] array2D = CreateMatrixNM(3, 4, -100, 100);
PrintMatrix(array2D);
SquareMatrix(array2D);
Console.WriteLine();
PrintMatrix(array2D);