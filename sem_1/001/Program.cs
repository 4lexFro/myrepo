// На входе принимает одно число N,
// а на выходе показывает все целые числа от -N до N

Console.WriteLine("Start");
int N;
Console.Write("Введите N ");

// int N = Convert.ToInt32(Console.ReadLine());
// или

N = int.Parse(Console.ReadLine());
int index = -N;
while (index <= N)
{
    Console.Write(index + " ");
    index = index + 1;
}

Console.WriteLine("End");
