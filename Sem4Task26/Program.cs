int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int numLength(int n)
{
    return Convert.ToInt32(Math.Log(n, 10));
}

int n = ReadData("Введите число");
Console.WriteLine("количество цифр в числе = " + numLength(n));