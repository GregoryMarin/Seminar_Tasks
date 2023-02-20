// Напишите программу, которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго.
// a = 25, b = 5 => да;
// a = 2, b = 10 => нет;

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
    System.Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
}