// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет      с методом

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Vihod(int day)
{
    if (day > 5)
    {
        return true;
    }

    return false;
}
bool CheckDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine(" Это не день недели! ");
    return false;
}
int day = Prompt(" Введите число: ");

if (CheckDay(day))
{
    if (Vihod(day))
    {
        Console.WriteLine(" Выходной ");
    }
    else
    {
        Console.WriteLine(" Рабочий ");
    }
}
