// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = CountNumbers(number);
// System.Console.WriteLine(result);


// int CountNumbers(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num/10;
//         count++;
//     }
//     return count;
// }

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int CountDigit(int insertNum)//Счетчик количества разрядов в числе
{
    int temp = 0;
    while (insertNum != 0)//!=0 на тот случай если пользователь ввел отрицательное значение
    {
        insertNum = insertNum / 10;
        temp++;
    }
    return temp;
}

int userNumber = InsertDigit("Введите число");
int count = CountDigit(userNumber);

Console.WriteLine($"Количество цифр в числе {userNumber} = {count}");