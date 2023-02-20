// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InsertDigit (string text)
{
    System.Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int DegreeNumber(int num, int degr)
{
    int result = 1;
    for (int i = 0; i < degr; i++)
    {
        result = result * num;
    }
    return result;
}

int number = InsertDigit("Введите число: ");
int degree = InsertDigit("Введите натуральную степень числа: ");
int resultDegree = DegreeNumber(number, degree);
if (degree > 0) System.Console.WriteLine(resultDegree);
else System.Console.WriteLine("Не корректные данные! Не натуральное число степени или степень нулевая!");