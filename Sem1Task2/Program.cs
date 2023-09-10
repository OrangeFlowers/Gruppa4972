// Задача №2
// Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("ВВедите число 1:");
int a = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("ВВедите число 2:");
int b = int.Parse(Console.ReadLine()??"0");
int max = a;
int min = b;

if (a>b)
{
   Console.Write("max = ");
   Console.WriteLine(max);
   Console.Write("min = ");
   Console.WriteLine(min); 
}
else
{
    if (a<b) max=b; min=a;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}







