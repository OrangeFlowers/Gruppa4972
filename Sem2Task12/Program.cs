// Задача №12
// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
void Variant1()
{
Console.WriteLine("Введите число 1");
int numA = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2");
int numB = int.Parse(Console.ReadLine()??"0");

if(numB%numA==0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число некратно первому, остаток от деления "+numB%numA);

}
}

void Variant2()
{
int f = int.Parse(Console.ReadLine()??"0");
int s = int.Parse(Console.ReadLine()??"0");

Console.WriteLine((s%f==0)?true:s%f);
}

Variant1();
Variant2();