// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int num = InsertPos("Введите число");
int InsertPos(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] Fibonacci(int num)
{
    int[] fibo = new int[num];
    fibo[1] = 1;

    for (int i = 2; i < num; i++)
    {
        fibo[i] = fibo[i - 2] + fibo[i - 1];
    }
    return fibo;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
int[] fiboArray = Fibonacci(num);
PrintArray(fiboArray);