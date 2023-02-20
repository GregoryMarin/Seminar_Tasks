// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}
double[] FillRndArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 1, MidpointRounding.ToZero);
    }
    return array;
}

int UserInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    int i = 0;
    double min = array[i];
    for (; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int sizeArray = UserInput("Введите размер массива: ");
int minValue = 0, maxValue = 100;
double[] array = FillRndArray(sizeArray, minValue, maxValue);
double maxNumber = FindMax(array);
double minNumber = FindMin(array);
double difference = maxNumber - minNumber;
double diff = Math.Round(difference, 1, MidpointRounding.ToZero);

PrintArray(array);
Console.Write($" -> {diff} (разница между максимальным и минимальным значением массива)");