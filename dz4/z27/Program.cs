// Задача 27: Напишите метод, который принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine(" Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElements(int number)
{
    int len = Convert.ToString(number).Length;

    int sum = 0;

   for (int i = 0; i < len; i++)
    {
        while (number > 0)
        {
            sum = sum + number % 10;
            number /= 10;
        }
    }
    return sum;
}

int sum = SumElements(number);
Console.WriteLine("Сумма : " + sum);
