// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Method(int n1)
{
    while (n1 < 100000 && n1 > 9999)
    {
        int firstDig = n1 / 10000;
        int secondDig = n1 / 1000 % 10;
        int forthDigit = n1 / 10 % 10;
        int lastDigit = n1 % 10;
        if (firstDig == lastDigit && secondDig == forthDigit)
        {
            System.Console.WriteLine("Это полиндром");
        }   
        else
        {
            System.Console.WriteLine("Это не полиндром");
        }
        break;
    }
}

if (num < 100000 && num > 9999)
{
    Method(num);
}
else
{
    System.Console.WriteLine("Это не пятизначное число");
}