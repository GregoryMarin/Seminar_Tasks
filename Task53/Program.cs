// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю сроку массива

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

void ChangeMatrixRow(int[,] matrix)
{
    int size = matrix.GetLength(1) / 2;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int firstRow = matrix[i, j];
            int lastRow = matrix[matrix.GetLength(0) - 1, j];
            int change = matrix[matrix.GetLength(0) - 1, j];
            matrix[i, j] = change;
            matrix[matrix.GetLength(0) - 1, j] = firstRow;
        }
    }
}

int rowSize = UserEnter("Write a row size: ");
int columnSize = UserEnter("Write  a column size: ");
int[,] matrix = new int[rowSize, columnSize];

FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

ChangeMatrixRow(matrix);
PrintMatrix(matrix);
