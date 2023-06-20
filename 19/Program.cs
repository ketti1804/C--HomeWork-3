/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine ("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
if (N < 10000 || N > 100000)
{
   Console.WriteLine ("Введено неверное число"); 
   return;
}
int a = N%10;
int b = N%100/10;
int c = N/10000;
int d = N/1000%10;
if (a == c) {
    if (b==d) Console.WriteLine ("да");
} 
else Console.WriteLine ("нет");
