// Задача №64.
// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Ввод данных с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Rec(int num)
{
    Console.Write(num+ " ");
    if (num <= 1) // Проверка для остановки рекурсии
    {

    }
    else
    {
        Rec(num - 1); //Вызов самого себя(рекурсия)
    }
}

 int num = ReadData("Введите число N: ");
 Rec(num);