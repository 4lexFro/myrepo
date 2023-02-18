// Показать четные числа от 1 до N
// int index = 2;
//while (index <= N)
//{
//    Console.WriteLine(index);
//    index = index + 2
//}

void EvenNumbers(int N)                        // { Метод вычисления четных чисел
{                                              
    int index = 2;                             
    while (index <= N)                         
    {                                        
        System.Console.WriteLine(index);
        index = index + 2;
    }
}                                               //}


int GetNumber(string text)                        // { Метод введения числа 
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}                                                 // }

int N = GetNumber(" Введите число: ");            // Вызов метода введения числа
EvenNumbers(N);                                   // Вызов метода вычисления четных