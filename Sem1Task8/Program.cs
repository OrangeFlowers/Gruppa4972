// Задача №8
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()??"0");
int N2 = 2;
if (N % 2 != 0)
{
    N = N - 1;
}

while (N2 < N)
{
    Console.Write(N2+ ",");
    N2=N2 + 2;
}

Console.WriteLine(N);