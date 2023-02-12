// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите a ");
Console.WriteLine("Введите b ");
Console.WriteLine("Введите c ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max;
max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.Write("max = ");
Console.WriteLine(max);
