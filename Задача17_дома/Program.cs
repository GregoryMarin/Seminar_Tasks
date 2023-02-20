// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y),
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.

System.Console.WriteLine("Задайте целое число точки координат Х: ");
int numX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте целое число точки координат Y: ");
int numY = Convert.ToInt32(Console.ReadLine());

int Method(int xpoint, int ypoint)
{
    int result = 0;
    if (xpoint > 0 && ypoint > 0) result = 1;
    if (xpoint > 0 && ypoint < 0) result = 2;
    if (xpoint < 0 && ypoint < 0) result = 3;
    if (xpoint < 0 && ypoint > 0) result = 4;
    return result;
}

System.Console.WriteLine($"Введенные цифры соответствуют квадрату {Method(numX, numY)} в системе координат.");