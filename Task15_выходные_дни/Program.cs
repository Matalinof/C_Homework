/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());

if (num < 6 & num > 0)
{
    System.Console.WriteLine("No");
}
if (num == 6 || num == 7)
{
    System.Console.WriteLine("Yes");
}
if (num<0 || num >7)
{
    System.Console.WriteLine("Цифра должна быть меньше 7 и больше 0");
}