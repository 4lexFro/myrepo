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

int IndexOf(int[] collection, int find) // Метод IndexOf с данными из collection и 
// есть еще некое значение find
{
    int count = collection.Length;
    int index = 0;
    //int position = 0;
    int position = -1; // Придумали ставить -1 для того ,чтобы ,при введении числа,
    // не входящего в данный массив [1,10], прказывало -1 ,т.е такого числа нет

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Массив из десяти элементов

Method(array); // Вызвали данный метод для заполнения массива
array[4] = 4; // Добавим искусственно четверки на позиции 4 и 6 для проверки того,
// что break отсечет вторую четверку.
array[6] = 4;
PrintArray(array); // Вызвали данный метод для распечатки массива
Console.WriteLine(); // Пустая для того,чтобы это не было решением предыдущих методов

int pos = IndexOf(array, 45); // Введем величину pos как результат работы метода IndexOf
// и запросим показать число с индексом 4

Console.WriteLine(pos);
