/*
Принимает на вход number и выводит, является ли число четным.
*/

System.Console.WriteLine("Задай число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
/*{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное);
}
*/
//System.Console.WriteLine("Задай число");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} чётное");
}
else
{
    System.Console.WriteLine($"Число {number} нечётное");
}