// Задача 4: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

void Max(int n1, int n2, int n3)
{
    if (n1>n2&&n1>n3) System.Console.WriteLine($"Максимальное число = {n1}");
    if (n2>n1&&n2>n3) System.Console.WriteLine($"Максимальное число = {n2}");
    if (n3>n2&&n3>n1) System.Console.WriteLine($"Максимальное число = {n3}");
}
Max(number1, number2, number3);