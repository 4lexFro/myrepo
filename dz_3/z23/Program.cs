//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(" Введите число: ");
int number = int.Parse(Console.ReadLine());
int index = 1;
while (index <= number)
{
    
    int cub = Convert.ToInt32(Math.Pow(index, 3));
    Console.WriteLine(cub);
    index++;
}
