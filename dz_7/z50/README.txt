// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.WriteLine(" Введите строку элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите столбец элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);


int[,] array = new int[a, b];


void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);

if (m <= a && n <= b)
{
    Console.Write("Значение элемента: " + array[m - 1, n - 1]);
}
else
{
    Console.Write("Такого числа в массиве нет ");
}
Console.WriteLine();
