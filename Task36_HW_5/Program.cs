// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов находяхщихся на нечетных позициях
// [3, 7, 23, 12] -> 19;
// [-4, -6, 89, 6] -> 0;

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1) Console.Write(", ");
    }
    Console.Write("] ");
}

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int CountNumbers(int[] array)
{
    int counter = 0;
    for (int i = 1; i < array.Length;)
    {
        counter = array[i] + counter;
        i = i + 2;
    }
    return counter;
}

int UserInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = UserInput("Введите размер массива: "), minValue = 0, maxValue = 100;
int[] array = FillArray(sizeArray, minValue, maxValue);
int counter = CountNumbers(array);
Console.Write("Массив: ");
PrintArray(array);
Console.Write($" -> {counter} (сумма нечетных позиций индекса)");

