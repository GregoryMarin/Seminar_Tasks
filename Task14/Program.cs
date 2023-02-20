// 14. Напишите программу которая принимает на вход число и проверяет кратно ли оно одновременно на 7 и 23
// 14 => нет
// 46 => нет
// 161 => да

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Multiple(int n)
{
    if (n % 7 == 0 && n % 23 == 0) Console.WriteLine($"{n} => Yes");
    else Console.WriteLine($"{n} => No");
}

Multiple(num);