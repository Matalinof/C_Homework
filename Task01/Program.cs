/*
Напишите программу, которая принимает 2 числа и проверяет является ли первое число квадратом второго
*/

System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(System.Console.ReadLine());

if (number1 == number2 * number2)
{
    System.Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    System.Console.WriteLine("Не квадрат");
}