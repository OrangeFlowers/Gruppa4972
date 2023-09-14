// Задача №10 
// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
void Variant1()
{
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");
if(num>100 && num<1000)
//проверяем введенное число, чтоб было трехзначным
{
    int num1 = num/10;
    //делим введенное трехзначное число, чтобы получить двухзначное
    int num2 = num1%10;
    //находим остаток двухзначного числа
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}
}

void Variant2()
{
Console.WriteLine("Введите число:");
string line = Console.ReadLine()??"0";
char[] digits = line.ToCharArray();
//переводим трехзначное число в массив
Console.WriteLine(digits[1]);
}

Variant1();
Variant2();
