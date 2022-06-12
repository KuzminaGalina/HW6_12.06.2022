/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    if(k1 != k2)
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*x + b1;
        Console.WriteLine($"Точка пересечения двух прямых имеет следующие координаты: {x} , {y}");
    }
    else
    {
        Console.WriteLine("Прямые являются параллельными");
    }

}

int b1 = 2;
int k1 = 5;
int b2 = 4;
int k2 = 9;

IntersectionPoint (b1, k1, b2, k2);