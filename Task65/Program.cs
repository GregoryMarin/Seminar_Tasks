// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите натуральное число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(numberM, numberN);

void NaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    Console.Write($"{numM} ");
    NaturalNumbers(numM + 1, numN);
    if (numM == numN) return;
}

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
// {
//     int result; bool parse;
//     Console.WriteLine(text);
//     parse = Int32.TryParse(Console.ReadLine(), out result);
//     if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
//     return result;
// }


// void IntegerNumbers(int n, int m, int s)
// {
//     if (n == m)
//     {
//         Console.Write($"{n} ");
//         return;
//     }
//     IntegerNumbers(n + s, m, s);

//     Console.Write($"{n} ");
// }

// int mUser = InsertDigit("Введите число N:");
// int nUser = InsertDigit("Введите число M:");

// int sign=Math.Sign((mUser-nUser));
// Console.WriteLine($"sign = {sign}");

// IntegerNumbers(nUser, mUser, sign);