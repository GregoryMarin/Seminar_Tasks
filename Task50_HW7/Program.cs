// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = UserEnter("Write row amount: ");
int column = UserEnter("Write column amount: ");

if (row <= 0 || column <= 0)
{
    Console.WriteLine("Numbers can't be 0 or > 0 ! ");
}
else
{
    int[,] matrix = CreateMatrix(row, column);
    PrintMatrix(matrix);
    Console.WriteLine();

    int rowNum = UserEnter("Write row number you want to see: ");
    int colNum = UserEnter("Write column number you want to see: ");

    if (rowNum <= 0 || colNum <= 0)
    {
        Console.WriteLine("Numbers can't be 0 or > 0 ! ");
    }
    else
    {
        if (rowNum > row && colNum > column || rowNum < row && colNum > column || rowNum > row && colNum < column)
        {
            Console.WriteLine($"{rowNum}, {colNum} -> There is no such element in the matrix");
        }
        else Console.WriteLine($"{matrix[rowNum, colNum]} -> matrix element according to the parameters you set");
    }
}