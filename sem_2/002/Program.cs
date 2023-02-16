// Принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine(" Введите число: ");
int value = int.Parse(Console.ReadLine());
if (value % 7 == 0 && value % 23 == 0) // именно двойное == , здесь остаток от деления 
// на 7 и 23 должен РАВНЯТЬСЯ 0
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
