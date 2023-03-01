// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементами массива.
// 3 7 22 2 78] -> 76
Console.WriteLine(" Ввести размер массива ");
int size = Convert.ToInt32(Console.ReadLine());

//------------------------------------------------------------------
double[] array = new double[size]; // Создание массива,заполнение его вещественными числами
int i = 0; // и распечатка
Random random = new Random();
for (i = 0; i < size; i++)
{
    array[i] = Math.Round(random.NextDouble() * 100, 1);
    Console.Write(array[i] + "  ");
}
Console.WriteLine();

//-------------------------------------------------------------------
double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    else if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine($"Мин: {min}");
Console.WriteLine($"Макс: {max}");
Console.WriteLine($"Разница: {max-min}");
