// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

System.Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Kub(int n1)
{
    int counter = 1;
    while (counter <= n1)
    {
        int multip = counter * counter * counter;
        System.Console.WriteLine($"{counter} | {multip}");
        counter++;
    }    
    if (num == 0) System.Console.WriteLine("Число не может быть нулем");
    if (num < 0) System.Console.WriteLine("Число должно быть положительным");
}
Kub(num);