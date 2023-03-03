// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1,  y = k2 * x + b2;  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xAxis(int b1, int b2, int k1, int k2)
{
    int x = (b1 - b2) / (k2 - k1);
    
    return x;
}


int yAxis( int k2, int b2, int x)
{
    int y = k2 * x + b2;
    return y;
}


void PrintResult( string text, int x, int y)
{
    System.Console.WriteLine($"{text}:({x}, {y})");
}

int k1 = GetNumber("Введите k1");
int k2 = GetNumber("Введите k2");
int b1 = GetNumber("Введите b1");
int b2 = GetNumber("Введите b2");
int x = xAxis(b1, b2, k1, k2);
int y = yAxis(k2, b2, x);
PrintResult("Прямые пересекаются в точке:", x, y);
