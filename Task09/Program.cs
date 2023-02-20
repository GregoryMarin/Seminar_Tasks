// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 => 8;
// 21 => 2;

int numb = new Random().Next(10, 100);
System.Console.WriteLine($"Случайное число = {numb}");


int MaxDigit(int n1)
{
    int lastnumber = numb % 10;
    int firstnumber = numb / 10;
    return firstnumber > lastnumber ? firstnumber : lastnumber;
}

System.Console.WriteLine($"Наибольшая цифра числа = {MaxDigit(numb)}");