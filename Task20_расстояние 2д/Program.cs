/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

System.Console.WriteLine("Задай координаты точки A x: ");
int userAX = int.Parse(Console.ReadLine());
System.Console.WriteLine("Задай координаты точки A y: ");
int userAY = int.Parse(Console.ReadLine());

System.Console.WriteLine("Задай координаты точки B: ");
int userBX = int.Parse(Console.ReadLine());
System.Console.WriteLine("Задай координаты точки: ");
int userBY = int.Parse(Console.ReadLine());

double sqrX = Math.Pow(userBX - userAX, 2); // Math.Pow(a, 2) функция возводит в степень (переменная, в какую степень возвести)
double sqrY = Math.Pow(userBY - userAY, 2);
double rootsqr = Math.Sqrt(sqrY + sqrX);
System.Console.WriteLine("Расстояние между точками равняется ");
//System.Console.WriteLine(Math.Round(rootsqr));
System.Console.WriteLine(rootsqr);