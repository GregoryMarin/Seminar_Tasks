// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int UserInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] FillArray(int sizeArr, string text)
{
    Console.WriteLine($"Введите {sizeArr} {text}: ");
    int[] newArr = new int[sizeArr];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArr;
}

int CounterPossitiveNumbers(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) counter++;
    }
    return counter;
}

string CorrectOutput(int numb)
{
    string text = "число";
    if (numb > 1 && numb < 5) text =  "числа";
    if (numb > 5) text = "чисел";
    return text;
}

string CorrectOutp2(int num)
{
    string text = "цифр";
    if (num == 1) text = "цифру";
    if (num > 1 && num < 5) text = "цифры";
    return text;
}

int size = UserInput("Введите количество вводимых вами цифр: ");
int[] array = FillArray(size, CorrectOutp2(size));
int counter = CounterPossitiveNumbers(array);
string corr = CorrectOutput(counter);
PrintArray(array);
if (counter == 0) Console.WriteLine(" -> в массиве, нет чисел больше нуля");
else Console.Write($" -> в массиве, {counter} {corr} больше нуля. ");