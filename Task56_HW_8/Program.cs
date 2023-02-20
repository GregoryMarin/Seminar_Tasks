// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}
int[] SummRowMatrix(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[] summRow = new int[size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summRow[i] += matrix[i, j];
        }
    }
    return summRow;
}
string FindMinValue(int[] arr)
{
    string text = String.Empty;
    int minValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minValue) minValue = arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == minValue) return text = $"{i+1} row";
    }
    return text;
}

int[,] matrix = CreateMatrix(3, 4, 1, 9);
int[] array = SummRowMatrix(matrix);
PrintMatrix(matrix);
PrintArray(array);
Console.WriteLine();
string result = FindMinValue(array);
System.Console.WriteLine($"Minimum value in the {result}");
