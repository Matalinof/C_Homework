/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Число не является трехзначным.");
}
else
{
    int thirdDigit = (num / 100) % 10;
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
