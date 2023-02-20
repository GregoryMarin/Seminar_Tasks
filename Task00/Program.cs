// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на себя)

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine($"{number * number}");
}
else
{
    System.Console.WriteLine("Число не может быть отрицательным или нулем");
}