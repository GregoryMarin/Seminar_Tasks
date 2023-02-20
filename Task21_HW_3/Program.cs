// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InsertPos(string text)
{
    System.Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}
int x1 = InsertPos("Введите координату Х первой точик: ");
int y1 = InsertPos("Введите координату Y первой точик: ");
int z1 = InsertPos("Введите координату Z первой точик: ");

int x2 = InsertPos("Введите координату Х второй точик: ");
int y2 = InsertPos("Введите координату Y второй точик: ");
int z2 = InsertPos("Введите координату Z второй точик: ");

double Length(int xl1, int xl2, int yl1, int yl2, int zl1, int zl2)
{
    double temp = (xl2 - xl1) * (xl2 - xl1) + (yl2 - yl1) * (yl2 - yl1) + (zl2 - zl1) * (zl2 - zl1);
    return Math.Sqrt(temp);
}
double result = Length(x1, x2, y1, y2, z1, z2);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);

System.Console.WriteLine($"Расстояние между точками = {resRound}");