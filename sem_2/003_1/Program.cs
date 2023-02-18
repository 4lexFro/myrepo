// Показать четные числа от 1 до N
// int index = 2;
//while (index <= N)
//{
//    Console.WriteLine(index);
//    index = index + 2
//}

string EvenNumbers(int N)                        // { Метод вычисления четных чисел
{    
    string output = "" ;                                        
    int index = 2;                             
    while (index <= N)                         
    {                                        
        output = output + index + "";
        index = index + 2;
    }

    return output;
}                                               //}


int GetNumber(string text)                        // { Метод введения числа 
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}                                                 // }

int N = GetNumber(" Введите число: ");            // Вызов метода введения числа
string result = EvenNumbers(N);  
System.Console.WriteLine(result);                                 // Вызов метода вычисления четных