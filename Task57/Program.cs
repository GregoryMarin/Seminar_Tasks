// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 1) Создаем двумерный массив
// 2) переводим двумерный м в одномерный
// 3) сортируем по возростанию
// 4) выводим сколько каких цифр

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] CreateArrayFromMatrix(int[,] matr)
{
    int[] arr = new int[matr.Length];
    for (int i = 0; i < matr.GetLength(0); i++)    // кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // кол-во столбцов
        {
            // arr[count] = matr[i, j];
            arr[i * matr.GetLength(1) + j] = matr[i, j];  // 2 * 3 + 0
        }
    }
    return arr;
}

//метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.WriteLine(array[i] + "]");
    }
}

void CountDictionary(int[] arr)
{
    int count = 1;
    int num = arr[0];                        // [2 7 7 4 9 3]
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
            count++;
        else
        {
            Console.WriteLine($"Количество чисел {num} = {count} ");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"Количество чисел {num} = {count} ");
}


int[,] array2D = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();

int[] array1D = CreateArrayFromMatrix(array2D);
PrintArray(array1D);
Array.Sort(array1D);

Console.WriteLine(string.Empty);
PrintArray(array1D);
Console.WriteLine(string.Empty);

CountDictionary(array1D);