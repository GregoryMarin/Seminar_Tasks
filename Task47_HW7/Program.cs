// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    double[,] rndMatr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < rndMatr.GetLength(0); i++)
    {
        for (int j = 0; j < rndMatr.GetLength(1); j++)
        {
            rndMatr[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(rndMatr[i, j], 1, MidpointRounding.ToZero);
        }
        System.Console.WriteLine();
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int sizeRow = UserEnter("Write a row value: ");
int sizeColumn = UserEnter("Write a column value: ");
int minValue = UserEnter("Write a minimum value or numbers: ");
int maxValue = UserEnter("Write a maximum value of numbers: ");

double[,] fill = FillMatrix(sizeRow, sizeColumn, minValue, maxValue);
PrintMatrix(fill);