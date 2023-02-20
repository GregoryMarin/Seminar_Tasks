// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для пользователя.

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-10, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

void ReplaceRowToCol(int[,] matrix)
{
    int temp = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int rowSize = UserEnter("Write a row size: ");
int columnSize = UserEnter("Write  a column size: ");
int[,] matrix = new int[rowSize, columnSize];

FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    ReplaceRowToCol(matrix);
    PrintMatrix(matrix);
}
else Console.WriteLine("Impossible");