// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// нельзя использовать Math.Pow
// 3, 5 -> 243 // 3 в пятой степени
// 2, 4 -> 16


int nomerA = ReadInt("Введите число: ");
int nomerB = ReadInt("Введите степень: ");
Stepen(nomerA, nomerB);

// Метод возведения в степень:
static void Stepen(int x, int 
y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    Console.WriteLine(" Результат : " + result);
}

// Метод ввода чисел:
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}