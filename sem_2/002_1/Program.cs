
// Принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да
bool Check(int value)
{
    return value % 7 ==0 && value % 23 == 0;
}

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Check(a));