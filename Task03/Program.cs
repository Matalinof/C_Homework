/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру
*/

System.Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(System.Console.ReadLine());

if (day == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (day == 2)
{
    System.Console.WriteLine("Tuesday");
}
if (day == 3)
{
    System.Console.WriteLine("Wednesday");
}
if (day == 4)
{
    System.Console.WriteLine("Thursday");
}
if (day == 5)
{
    System.Console.WriteLine("Friday");
}
if (day == 6)
{
    System.Console.WriteLine("Saturday");
}
if (day == 7)
{
    System.Console.WriteLine("Sunday");
}