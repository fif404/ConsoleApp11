// Скрипников Сергей 17вариант 2.1
Console.WriteLine("Введите число A:");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите B:");
double B = double.Parse(Console.ReadLine());
Console.WriteLine("Введите D");
double D = double.Parse(Console.ReadLine());
Console.WriteLine("Введите C");
double C = double.Parse(Console.ReadLine());
if (((A % 3 == 0) && (B % 5 == 0) && (D % 3 == 0) && (C % 5 == 0)) || ((A % 5 == 0) && (B % 3 == 0) && (D % 5 == 0) && (C % 3 == 0)))
    Console.WriteLine("чилсо делится нацело");
else
    Console.WriteLine("число не делиться");