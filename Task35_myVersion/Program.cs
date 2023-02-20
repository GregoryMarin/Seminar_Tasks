// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ", ");
        else System.Console.Write(array[i]);
    }
    System.Console.Write(" ]");
}

int CountNumInDiapozone(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 100 && array[i] >= 10) count++;
    }
    return count;
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int arraySize = 123, arrayMinValue = 0, arrayMaxValue = 999;
int[] newArray = CreateArray(arraySize, arrayMinValue, arrayMaxValue);

int findNumb = CountNumInDiapozone(newArray);
PrintArray(newArray);
System.Console.WriteLine($"-> {findNumb}");

