void Method(int[] collection) // метод с названием Method
{
    int length = collection.Length; // Длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Обратиться к collection на позиции index
        // и положить туда случайное значение из интервала от 1 до 10
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)  // Метод выведения массива.Значения надо называть по разному,
// поэтому было collection ,стало col. Void не возвращает данные
{
    int count = col.Length; // кол-во элементов
    int position = 0; // индекс не через index, а через позицию position
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}


int[] array = new int[10]; // Массив из десяти элементов

Method(array); // Вызвали данный метод для заполнения массива
PrintArray(array); // Вызвали данный метод для распечатки массива
