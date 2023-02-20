// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Создание рандомного двумерного массива int
int[,] CreatMatrixNM(int rows, int columns, int min, int max)
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

int SummMatrix(int[,] matrix)
{
    int summMatr = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) summMatr += matrix[i, j];
        }
    }
    return summMatr;
}

int[,] arr1 = CreatMatrixNM(5, 4, 1, 10);
int summ = SummMatrix(arr1);
PrintMatrix(arr1);
System.Console.WriteLine($"Сумма элементов главной диагонали: {summ}");

