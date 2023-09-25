// Задача №17 
// Про методы. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X и Y не равны 0 и выдает номер плоскости, в которой находится эта точка.

// 1) ввести X
// 2) ввести Y
// 3) поиск ответа
// 4) вывести результат

//вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//по координатам точки определяем номер четверти
int QuterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
//печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

int res = QuterTest(x,y);

PrintResult("Точка находится в четверти № "+res);