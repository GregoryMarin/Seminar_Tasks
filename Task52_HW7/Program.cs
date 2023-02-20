// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[] array)
{
    Console.Write("[");
    Console.Write("The average of every columns: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], 1, MidpointRounding.ToZero);
        Console.Write($"{i + 1} = {array[i]}");
        if (i < array.Length - 1) Console.Write("; ");
    }
    Console.WriteLine("]");
}

double[] Array(int[,] matrix)
{
    
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int summColumn = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summColumn += matrix[i, j];
        }
        average[j] = (double)summColumn / matrix.GetLength(0);
    }
    return average;
}

int row = UserEnter("Write a row of matrix: ");
int column = UserEnter("Write a column of matrix: ");
int[,] matrix = new int[row, column];

Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

double[] result = Array(matrix);
PrintArray(result);