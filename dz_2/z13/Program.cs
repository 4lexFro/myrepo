Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Решение:
--------

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
 
int Find3Num(int number)
{ 
    wile (number > 999);
    {
       number /= 10;
    }
    return number % 10;
}

bool CheckNumber (int number)
{
    if (number < 100)
    {
       Console.WriteLine(" Третьей цифры нет ");
       return false;
    }
    return true;
}  

int number = Prompt(" Введите число: ");
if (CheckNumber(number))

{
    Console.WriteLine(Find3Num(number));
}
