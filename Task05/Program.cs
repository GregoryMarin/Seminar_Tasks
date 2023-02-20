// Напишите программу которая принимает на вход число (N), а на выходе показывает все целые числа
// от (-N) до (N) включительно

System.Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int counter = -n;

while (counter != n)
{
    System.Console.Write($" {counter}");
    counter++;
}