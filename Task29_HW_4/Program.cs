// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void PrintArray(int[] num)
{
    System.Console.Write("Вы ввели числа: [ ");
    int size = num.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{num[i]}, ");
    }
    System.Console.WriteLine("]");
}

int FillArray(int[] num)
{
    Random rnd = new Random();
    int size = num.Length;
    for (int i = 0; i < size; i++)
    {
        num[i] = rnd.Next(0, 100);
    }
    return size;
}

int[] numbers = new int[8];
System.Console.WriteLine("Введите 8 чисел: ");
FillArray(numbers);
PrintArray(numbers);