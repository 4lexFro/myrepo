// На входе принимает одно число N,
// а на выходе показывает все целые числа от -N до N

Console.WriteLine("Start");

Console.Write("Введите N: ");

int N = Convert.ToInt32(Console.ReadLine());
// или
// int N = int.Parse(Console.Readline());
int index = -N;
while (index <= N)
{
    Console.WriteLine(index);
    index = index + 1;
}

Console.WriteLine("End");
