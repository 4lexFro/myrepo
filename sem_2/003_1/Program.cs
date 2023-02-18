// Показать четные числа от 1 до N
int N = 12;
// int index = 2;
//while (index <= N)
//{
//    Console.WriteLine(index);
//    index = index + 2
//}

void EvenNumbers(int N)
{
    int index = 2;
    while (index <= N)
    {
        System.Console.WriteLine(index);
        index = index + 2;
    }
}

EvenNumbers(N);