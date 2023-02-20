// 16. Напишите программу, которое принимает на вход 2 числа и проверяет
// является ли одно число квадратом другого;
// 5, 25 => да;
// -4, 16 => да;
// 8, 9 => нет;

System.Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

void Square(int n1, int n2)
{
    if (n1 == n2 * n2 || n2 == n1 * n1) Console.WriteLine($"{n1}, {n2} => да");
    else System.Console.WriteLine($"{n1}, {n2} => нет");
}

Square(number1, number2);