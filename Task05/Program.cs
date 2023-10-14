/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
*/

System.Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
/*int N = number;
while(N < number + 1)
{
    System.Console.Write(N+ "_" );
    N = N + 1;
}
*/
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
    if (i < number)
        System.Console.Write(", ");
}