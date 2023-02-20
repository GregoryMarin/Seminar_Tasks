// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
            if (j < matrix.GetLength(1) - 1) Console.Write(", ");
        }
        Console.WriteLine("  ]");
    }
    Console.WriteLine();
}

void OrderMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 1; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k - 1] < matrix[i, k])
                    {                                         //     0 1 2 3
                        int temp = matrix[i, k - 1];          // 0   8 7 6 4 
                        matrix[i, k - 1] = matrix[i, k];      // 1   6 3 5 8
                        matrix[i, k] = temp;                  // 2   4 1 7 9
                    }
                }
            }
        }
    }
}

int[,] matrix = CreateMatrix(3, 4, 1, 9);
PrintMatrix(matrix);
OrderMatrix(matrix);
PrintMatrix(matrix);
