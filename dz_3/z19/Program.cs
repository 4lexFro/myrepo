// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool Palindrom(string number)
{
    int len = number.Length;
    if (len == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine("Палиндром");
            return true;
        }
        else
        {
            Console.WriteLine("Не палиндром");
            return false;
        }
        return true;
    }
    else
    {
       Console.WriteLine("Введите пятизначное число: "); 
    }
    return false;
}

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

bool result = Palindrom(number);
// if (result == true)
// {
   // Console.WriteLine("Палиндром");
// }
// else
// {
    // Console.WriteLine("Не палиндром");
// }
 //Console.WriteLine(result);
