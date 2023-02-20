// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// в общем, приравниваем правые части данных равенств:
// k1*x+b1=k2*x+b2
// выразим отсюда x:
// x=(b2-b1)/(k1-k2)
// затем подставим полученное значение х в выражение для у (для любого, например первого) :
// y=k1(b2-b1)/(k1-k2)+b1
// ответ: x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1

double UserInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double FindX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double b1, double b2, double k1, double k2)
{
    double y = k1 * (b2-b1)/(k1-k2) + b1;
    return y;
}

void ResXY(double x, double y)
{
    double firstNumber = x;
    double secondNumber = y;
    Console.WriteLine($"({firstNumber}, {secondNumber})");
}

double b1 = UserInput("Введите цифру точки b1: ");
double b2 = UserInput("Введите цифру точки b2: ");
double k1 = UserInput("Введите цифру точки k1: ");
double k2 = UserInput("Введите цифру точки k2: ");

double resultX = FindX(b1, b2, k1, k2);
double resultY = FindY(b1, b2, k1, k2);

Console.WriteLine($"Значение X = ({resultX}), значение Y = ({resultY})");
ResXY(resultX, resultY);
