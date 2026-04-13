using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Point
{
    // объявление полей
    private double x;
    private double y;

    // конструктор
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // метод, вычисляющий расстояние от одной точки до другой (результат - double)
    public double DistanceTo(Point other)
    {
        double dx = other.x - this.x;
        double dy = other.y - this.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // ++ увеличивает x на 1
    public static Point operator ++(Point p)
    {
        return new Point(p.x + 1, p.y);
    }

    // -- уменьшает x на 1
    public static Point operator --(Point p)
    {
        return new Point(p.x - 1, p.y);
    }

    // явное приведение к int (целая часть x)
    public static explicit operator int(Point p)
    {
        return (int)p.x;
    }

    // неявное приведение к double (y)
    public static implicit operator double(Point p)
    {
        return p.y;
    }

    // расстояние
    public static double operator +(Point a, Point b)
    {
        return a.DistanceTo(b);
    }

    // Point + int (увеличиваем x)
    public static Point operator +(Point p, int value)
    {
        return new Point(p.x + value, p.y);
    }

    // int + Point (увеличиваем x)
    public static Point operator +(int value, Point p)
    {
        return new Point(p.x + value, p.y);
    }

    public override string ToString()
    {
        return "точка (" + x  + ";"+ y+ ")";
    }

}
