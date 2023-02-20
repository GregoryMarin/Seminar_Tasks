// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ParseIn2(int num)
{
    if (num == 0) return 0;
    int result = num % 2;
    num /= 2;
    result += ParseIn2(num) * 10;
    return result;
}
//Console.WriteLine(ParseIn2(Convert.ToInt32(Console.ReadLine())));
Console.WriteLine("Введите число");
var num =Console.ReadLine();
Console.WriteLine(ParseIn2(Convert.ToInt32(num)));