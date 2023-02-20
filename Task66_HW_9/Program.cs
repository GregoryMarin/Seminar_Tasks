// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = UserEnter("Write a min value: ");
int numberN = UserEnter("Enter a maximum value: ");

int SumNumbers(int num, int num1)
{
    if (num == num1+1) return 0;
    else return num + SumNumbers(num+1, num1);
}

System.Console.WriteLine();
Console.WriteLine($"Сумма элементов в промежутке {numberM} и {numberN} -> {SumNumbers(numberM, numberN)}");