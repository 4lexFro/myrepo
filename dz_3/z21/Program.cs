// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

static void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) 
    + Math.Pow(z2 - z1, 2)) , 0.5);

    Console.WriteLine("Расстояние равно:" + d);
    return;
}
    double x1 = 3;
    double y1 = 6;
    double z1 = 8;
    double x2 = 2;
    double y2 = 1;
    double z2 = -7;

    Distance(x1, y1, z1,
             x2, y2, z2);


