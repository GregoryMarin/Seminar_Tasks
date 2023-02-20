// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите натуральное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int counter = 0;
while (counter <= numb)
{
    if (counter % 2 == 0)
    {
        System.Console.Write($" {counter}");
    }
    counter++;
    
}
