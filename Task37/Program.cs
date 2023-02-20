// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] CreateRndArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int UserWrite(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] MultiplyElementsInArray(int[] arr)
{
    int sizeNew = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1; 
    int[] arrNew = new int[sizeNew];                                          
    if (arr.Length % 2 != 0) arrNew[arrNew.Length - 1] = arr[arr.Length / 2];  
    for (int i = 0; i < arr.Length / 2; i++)                                 
    { 
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrNew;
}

int size = UserWrite("Write arrays size: ");
int minValue = UserWrite("Write min value of array: ");
int maxValue = UserWrite("Write max value of array: ");
int[] newArray = CreateRndArray(size, minValue, maxValue);
int[] multiplyNumbers = MultiplyElementsInArray(newArray);
PrintArray(newArray);
PrintArray(multiplyNumbers);

