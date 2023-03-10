/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 0 строка */

int[,] array = new int [4, 7];
FillArray(array);
PrintArray(array);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]}  ");
        }
        Console.WriteLine();
    }
}


int SumLine(int[,] matr, int i)
{
    int sum = matr[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += matr[i,j];
    }

    return sum;

}

int minSum = 1;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
if (sum > SumLine(array, i))
{
sum = SumLine(array, i);
minSum = i+1;
}
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");
