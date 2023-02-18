// Реализовать перемешивание массива
// 1) Перемешивание массива
// 2) Создание массива
// 3) Печать массива
// 4) Заполнение массива
// 4.1  Руками
// 4.2  Случайно
// 5) Ввод числа

// 1. Создание массива

int[] CreateArray(int size)
{
    return new int[size];
}

// 2. Ввод числа

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// 3. Печать массива

string Print(int[] array)
{
    string result = String.Empty;  // Пустая строка
    int len = array.Length;       // Вводим переменную len , которая определяется длинной массива
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}

int size = GetNumber(" Введите размер массива ");
int[] numbers = CreateArray(size);
System.Console.WriteLine(Print(numbers));

