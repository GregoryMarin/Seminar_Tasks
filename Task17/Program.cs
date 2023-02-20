// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y),
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.

System.Console.WriteLine("Введите координаты точек: ");
System.Console.WriteLine("X: ");
int xdot = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y: ");
int ydot = Convert.ToInt32(Console.ReadLine());

void Xykoord(int x, int y)
{
    if (x > 0 && y > 0) System.Console.WriteLine("Указанные координаты соответствуют четверти = 1");
    if (x > 0 && y < 0) System.Console.WriteLine("Указанные координаты соответствуют четверти = 2");
    if (x < 0 && y < 0) System.Console.WriteLine("Указанные координаты соответствуют четверти = 3");
    if (x < 0 && y > 0) System.Console.WriteLine("Указанные координаты соответствуют четверти = 4");
}

if (xdot != 0 && ydot != 0) Xykoord(xdot, ydot);
else System.Console.WriteLine("Никакое значение, не может быть нулевым");