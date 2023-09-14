// Задача №16
// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine()??"0");

bool test1 = (num1 == num2*num2);

bool test2 = (num2 == num1*num1);

if(test1) Console.WriteLine("Первое число квадрат второго");
if(test2) Console.WriteLine("Второе число квадрат первого");

if(!(test1||test2))
{
    Console.WriteLine("Числа не квадраты друг друга");
}