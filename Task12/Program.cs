// 12. Напишите программу, которая на вход принимает 2 числа и выводить, ясляется ли первое число
// кратно второму. Если число 1 не кратно 2, то программа выводит остаток от деления.


System.Console.WriteLine("Введите два натуральных числа: ");
int first_number = Convert.ToInt32(Console.ReadLine());
int second_number = Convert.ToInt32(Console.ReadLine());

void Multiple(int n1, int n2)
{
    if (n1 % n2 == 0) Console.WriteLine($"Число {n1} кратно {n2}");
    else Console.WriteLine($"Число {n1} не кратно {n2}, отстаток = {n1 % n2}");
}

Multiple(first_number, second_number);