using System;
namespace df;
class Programm
{
    static void Main(string[] args)
    {
         int a = 5;
        /*int b = 7; 
         double s = 0.5 * a * b;
        Задание найти площадь треугольника сданными сторонами:
        Console.WriteLine(s);
        Задание найти гипотенузу по теореме Пифагорова
        double c1 = (Math.Pow(a, 2)) + (Math.Pow(b, 2));
        double c2 = Math.Sqrt(c1);
        Console.WriteLine(c2);
        ЗАДАНИЕ НАЙТИ ГИПОТЕНУЗУ ПО ФОРМУЛЕ ЧЕРЕЗ СИНУС*/
        double c = a / Math.Sin(90);
        Console.WriteLine(c);
    }
}