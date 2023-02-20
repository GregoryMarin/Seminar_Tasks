/* Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления). */

// Console.WriteLine("Введите 3-х значное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите трехзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int MiddleDigit(int n)
{
    return n / 10 % 10;
}

if (numb > 99 && numb < 1000) System.Console.WriteLine($"Вторая цифра числа {numb} = {MiddleDigit(numb)}");
else System.Console.WriteLine("Неверные данные");