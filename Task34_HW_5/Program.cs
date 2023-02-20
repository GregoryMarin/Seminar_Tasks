// Задайте массив заполненный случайными трехзначными положительными числами. Напишите программу, которая покажет количество
// четных чисел в массиве
// [345, 897, 568, 234] -> 2;

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] FillArrayRnd(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int UserInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = UserInput("Введите размер массива состоящий из трехзначных положительных чисел: ");
int minValue = 100, maxValue = 999;

int[] array = FillArrayRnd(sizeArray, minValue, maxValue);
int counter =  CountEvenNumbers(array);

Console.Write("В массиве: ");
PrintArray(array);
Console.Write($" -> {counter} четных чисел(а)");




