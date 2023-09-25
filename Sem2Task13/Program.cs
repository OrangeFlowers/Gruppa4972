// Задача №13
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// * Сделать вариант для числа длиной до 10 цифр не используя char или string (Variant3).

void Variant1()
{
Console.WriteLine("Введите число:");
string line = Console.ReadLine()??"0";
char[] digits = line.ToCharArray();

Console.WriteLine(digits[2]);
}

void Variant2()
{
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()??"0");
if(a>100 && a<1000)
{
    int b = a%10;
    Console.WriteLine(" Последняя цифра числа " +a+ " это " +b);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
}

void Variant3()
{
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()??"0");

while (n>1000) // Запускается цикл и приводит любое число в трехзначное
{
    n = n/10;
}
if(n>100 && n<1000)
{
     n = n%10; // Выполняется условие и выводится третья цифра числа
     Console.WriteLine(n);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
}








Variant1();
Variant2();
Variant3();