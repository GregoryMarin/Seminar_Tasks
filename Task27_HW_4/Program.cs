// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummNumbers(int num)
{
    int summ = 0;
    while(num != 0)
    {
        summ = summ + (num % 10);
        num = num / 10;
    }
    return summ;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = SummNumbers(number);
System.Console.WriteLine($"Сумма цифр введенного числа = {summ}");