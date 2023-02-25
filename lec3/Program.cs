// Функции.Продолжение

//1)Ничего не берут и ничего не возвращают:
//-----------------------------------------------

void Method1()
{
    Console.WriteLine(" Автор ...");
}

//Вызывается:

//Method1();
//=======================================================================

//2)  Ничего не возвращают,но могут принимать какие-то аргументы:
//-------------------------------------------------------------------

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(" Текст сообщения ");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method2_1(" Текст", 4);   // показать ТЕКСТ 4 раза
//Method2_1(msg: " Текст",count: 4);  // Можно использовать именованные значения
//Method2_1(count: 4 , msg: " Новый Текст"); // Неважен порядок аргументов
//========================================================================

// 3) Ничего не принимают,но что-то возвращают
//----------------------------------------------

int Method3() // Если он что-то возвращает,то надо указывать тип данных,
// которые мы ожидаем - int
{
    return DateTime.Now.Year;
}

int year = Method3();

//Console.WriteLine(year);

//==================================================================

//4) Что-то принимаю,что-то отдают:
//-----------------------------------

//string Method4( int count, string text) // Показать строку C count раз
//{
//  int i = 0;
//   string result = String.Empty; // Это начальное значение result - пустая строка
// типа, i = 0 и тд для типа данных string
//   while (i < count)
//   {
//        result = result + text;
//        i++;
//   }
//   return result;
//}

//string res = Method4(10, "qwerty");  // десять раз показать qwerty
//Console.WriteLine(res);

//=========================================================================

// Цикл for :

//for(int i = 0, i < 10, i++)
//{
// Console.WriteLine(i);
//}

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

//string res = Method4(10, "qwerty");
//Console.WriteLine(res);

//=================================================================

// Цикл внутри цикла:
//----------------------

// Вывод таблицы умножения на экран:
//-----------------------------------

for (int i = 2; i <= 10; i++) // Внешний цикл. i = 2 ,тк умножение начинается с 2.
{
    for (int j = 2; j <= 10; j++) // Внутренний цикл
    {
       // Console.WriteLine($"{i} * {j} = {i * j}"); // Интерполяция строк
    }
   // Console.WriteLine();
}

//======================================================================
// Дан текст.В тексте все пробелы надо заменить черточками,маленькие 
//буквы "к" заменить большими "К", а маленькие "в" заменить символами "&".

string text = "На краю дороги стоял дуб. Вероятно, в десять раз старше берез, составлявших лес,"
            + "он был в десять раз толще и в два раза выше каждой березы. Это был огромный в два "
            + " обхвата дуб с обломанными, давно видно, суками и с обломанной корой, заросшей старыми болячками.";

//string s = "qwerty"
//s[3] это будет r - символ из qwerty на позиции 3 будет r, 
// т.к отсчет,как в массиве, идет от 0.
// Метод будет принимать строку и те символы,которые надо будет менять
// Возвращаться тоже будет строка

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }
        return result;

}

string newText = Replace(text, ' ' , '|');
Console.WriteLine(newText);
Console.WriteLine(); // чтобы покрасивее было. разделить пустой строкой

newText = Replace(newText, 'к' , 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'в' , '&');
Console.WriteLine(newText);
