// Напишите программу, которая на вход принимает трехзначное число
// и на выходе показывает последнюю цифру этого числа.

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = number % 10;
    System.Console.WriteLine($"Последняя цифра числа = {result}");
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}