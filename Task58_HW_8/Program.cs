// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine(" ]");
    }
}
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] = result[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

int row1 = UserEnter("Write a row value: ");
int column1 = UserEnter("Write a column value: ");
int row2 = UserEnter("Write a row2 value: ");
int column2 = UserEnter("Write a column2 value: ");
int[,] array2D1 = CreateMatrixRndInt(row1, column1, 1, 5);
int[,] array2D2 = CreateMatrixRndInt(row2, column2, 1, 5);

Console.WriteLine("1'st matrix:");
PrintIntMatrix(array2D1);
Console.WriteLine();
System.Console.WriteLine("2'nd matrix");
PrintIntMatrix(array2D2);
Console.WriteLine();

if (array2D1.GetLength(0) == array2D2.GetLength(1))
{
    int[,] Array2DMult = MatrixMultiplication(array2D1, array2D2);
    Console.WriteLine("Result of multiplaying matrix:");
    PrintIntMatrix(Array2DMult);
}
else Console.WriteLine("Non correct matrix value");