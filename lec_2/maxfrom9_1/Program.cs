// Найти max из 9 чисел: создадим функцию max, которая будет искать максимум 
// из троек чисел. arg1 - a1,b1,c1 ; arg2 - a2,b,c2 ; arg3 - a3,b3,c3

int Max(int arg1, int arg2, int arg3) 

{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}

int a1 = 43;
int b1 = 593859;
int c1 = 17;
int a2 = 56;
int b2 = 7;
int c2 = 435;
int a3 = 86;
int b3 = 15;
int c3 = 3;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max (max1, max2, max3);

Console.WriteLine (max);