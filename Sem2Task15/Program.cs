// Задача №15
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Variant1()
{
Console.WriteLine("Введите число:");
int day = int.Parse(Console.ReadLine()??"0"); 
if (day>5)
{
    Console.WriteLine("Выходной день");
}
else
{
     Console.WriteLine("Рабочий день");
    
}
}

void Variant2()
{
Console.WriteLine("Введите число:");
int day = int.Parse(Console.ReadLine()??"0");
if(day>7 || day<1)
{
    Console.WriteLine("Число" +day+ "не является днем недели, введите число от 1 до 7");
}
else
{
    Dictionary <int, string> dayOfWeek=new Dictionary<int, string> // ввел конструкцию Dictionary и создал пары "ключ" и "значение"
{
    { 1, "Понедельник - рабочий день"},
    { 2, "Вторник - рабочий день"},
    { 3, "Среда - рабочий день"},
    { 4, "Четверг - рабочий день"},
    { 5, "Пятница - рабочий день"},
    { 6, "Суббота - выходной день"},
    { 7, "Воскресенье - выходной день"},
};
    Console.WriteLine(dayOfWeek[day]); // выводится значение по ключу
}
}

Variant1();
Variant2();