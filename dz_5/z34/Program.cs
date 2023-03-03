// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 Console.WriteLine(" Введите длину массива: ");

 int size = Convert.ToInt32(Console.ReadLine());

 int[] numbers = new int[size];

 FillArray(numbers); // Вызываем метод заполнения массива случайными числами

 Console.WriteLine(" В этом массиве: ");

 PrintArray(numbers); // Вызываем метод распечатки массива

 //--------------------------------------------------

 // Метод заполнения массива случайными числами

 void FillArray(int[] numbers)
 {
     for (int i = 0; i < size; i++)
     {
        numbers[i] = new Random().Next(100, 999);
     }
 }

 //--------------------------------------------------

 int count = 0;

 for (int a = 0; a < numbers.Length; a++)
 {
     if (numbers[a] % 2 == 0)
         count++;
 }

 Console.WriteLine($"из {numbers.Length} чисел {count} четных");

 // Метод распечатки массива

 //-----------------------------------------------------

 void PrintArray(int[] numbers)
 {
     Console.Write("[ ");
     for (int i = 0; i < numbers.Length; i++)
     {
         Console.Write(numbers[i] + " ");
     }
     Console.Write("]");
     Console.WriteLine();
 }


