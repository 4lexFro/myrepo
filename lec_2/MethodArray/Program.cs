// Имеется массив из n элементов ,
// требуется найти элемент массива ,равный find

int[] array = { 1, 34, 75, 51, 45, 38, 7, 68, 66, 5, };

int n = array.Length;
int find = 68;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    // index = index + 1
    {
        Console.WriteLine(index);
    }
    index++;
}
