using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите x первой точки: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Введите y первой точки: ");
        double y1 = double.Parse(Console.ReadLine());

        Point p1 = new Point(x1, y1);

        Console.Write("Введите x второй точки: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Введите y второй точки: ");
        double y2 = double.Parse(Console.ReadLine());

        Point p2 = new Point(x2, y2);


        double distance = p1.DistanceTo(p2);

        Console.WriteLine("Расстояние между точками: " + distance);

        // Унарные операции
        p1++;
        Console.WriteLine("p1.x + 1  = " + p1);

        p2--;
        Console.WriteLine("p2.x - 1 = " + p2);

        // Приведение типов
        int x = (int)p1;
        double y = p1;

        Console.WriteLine("int(x) = " + x);
        Console.WriteLine("double(y) = " + y);

        // Бинарные операции
        double dist = p1 + p2;
        Console.WriteLine("Distance: " + dist);

        Point p3 = p1 + 5;
        Console.WriteLine("p1.x + 5 = " + p3);

        Point p4 = 10 + p1;
        Console.WriteLine("10 + p1.x = " + p4);
    }
}