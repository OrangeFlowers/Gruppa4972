// Задача №68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
Console.Write (Akk(m, n));