/*
 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
 Если второе число некратно первому, то программа выводит остаток от деления. 
 34, 5 -> некратно, остаток 
 4 16, 4 -> кратно
 */

 System.Console.WriteLine("Задайте первое число: ");
 int number1 = Convert.ToInt32(Console.ReadLine());

int answer = number1/100;
int answer2 = number1/10%10;

System.Console.WriteLine(answer);
System.Console.WriteLine(answer2);