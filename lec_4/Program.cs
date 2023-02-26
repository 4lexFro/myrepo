// Двумерные массивы и рекурсия

// int[,] matrix = new int[5,8]; // запятая в квадратных скобках
// это показатель двумерности. 5 - количество строк, 8 - количество столбцов 
// в массиве

//string[,] table = new string[2, 5];
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]  // 0 - индекс элемента в строке;
// 0 1 2 3 4 - индекс элемента в столбце. Индексы идут с 0.
// table[0,0] table[1,0]   // 2 строки 
// String.Empty - инициализация строк


//table[1, 2] = " слово ";

//for (int rows = 0; rows < 2; rows++) // Строки 
//{
//    for (int columns = 0; columns < 5; columns++)  // Столбцы
//    {
        //Console.WriteLine($"-{table[rows, columns]}-");  
 //   }
//}

 

 int[,] matrix = new int[3, 4];
 
 for (int rows = 0; rows < 3; rows++)
 {
    for (int columns = 0; columns < 4; columns++)
    {
        Console.Write($"{matrix[rows, columns]} "); // пробел после фигурных скобок
    }
    Console.WriteLine(); // Добавляем перенос на новую строку для удобства
 }