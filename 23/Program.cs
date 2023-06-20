/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число (N > 1)");
int N = int.Parse(Console.ReadLine());
int I = 1;
if (N < I) 
{
    Console.WriteLine($"Введено неверное число");
    return;
}
while (N >= I)
{
    Console.Write($"{Math.Pow(I, 3)} ");
    I++;
}
for (int i = 1; N >= i; i++)
{
    Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)} ");
}
    
