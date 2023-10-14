/*
На вход подается трехзначное число. На выход получается последняя цифра числа
*/

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastnumber = number % 10;

System.Console.WriteLine($"Последняя цифра {lastnumber}");