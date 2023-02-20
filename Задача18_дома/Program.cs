// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти в системе координат:");
int num = Convert.ToInt32(Console.ReadLine());

string Method(int n1)
{
    string result = "0";
    if (num == 1) result = "x > 0 и y > 0";
    if (num == 2) result = "x > 0 и y < 0";
    if (num == 3) result = "x < 0 и y < 0";
    if (num == 4) result = "x > 0 и y < 0";
    if (num == 0) result = ("Цифра не может ровняться нулю");
    return result;
}

while (num != 0)
{
    if (num > 0 && num < 5) System.Console.WriteLine($"Возможный диапозон в этой четверти: {Method(num)}");
    else System.Console.WriteLine("Цифры должны быть от 1 - 4");
    break;
}
if (num == 0) System.Console.WriteLine("Цифра не может ровняться нулю");
