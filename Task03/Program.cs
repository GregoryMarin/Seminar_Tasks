// Напишите программу, которая будет выдавать название дня недели по заданному номеру

System.Console.WriteLine("Введите цифру: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) Console.WriteLine("The day is - Monday");
if (day == 2) Console.WriteLine("The day is - Tuesday");
if (day == 3) Console.WriteLine("The day is - Wednesday");
if (day == 4) Console.WriteLine("The day is - Thursday");
if (day == 5) Console.WriteLine("The day is - Friday");
if (day == 6) Console.WriteLine("The day is - Saturday");
if (day == 7) Console.WriteLine("The day is - Sunday");
if (day < 0 || day > 7) Console.WriteLine("Not such a day");
if (day == 0) Console.WriteLine("Not such a day");