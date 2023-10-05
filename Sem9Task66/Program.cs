// Задача №66
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int Rec(int m, int n)
{
    if (m > n) // Проверка для остановки рекурсии
    {
        return 0;
    }
    else
    {
        return Rec(m + 1, n) + m; //Вызов самого себя(рекурсия)

    }
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
Console.WriteLine((m > n) ? Rec(n, m) : Rec(m, n));