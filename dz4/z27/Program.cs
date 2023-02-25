// Задача 27: Напишите метод, который принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine(" Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElements(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int summa = SumElements(number);
Console.WriteLine("Сумма : " + summa);
