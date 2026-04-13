using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Point
{
    private double _x;
    private double _y;

    public Point(double x, double y)
    {
        this._x = x;
        this._y = y;
    }

    public double DistanceTo(Point other)
    {
        double dx = other._x - this._x;
        double dy = other._y - this._y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    public static Point operator ++(Point p)
    {
        return new Point(p._x + 1, p._y);
    }

    public static Point operator --(Point p)
    {
        return new Point(p._x - 1, p._y);
    }

    public static explicit operator int(Point p)
    {
        return (int)p._x;
    }

    public static implicit operator double(Point p)
    {
        return p._y;
    }

    public static double operator +(Point a, Point b)
    {
        return a.DistanceTo(b);
    }

    public static Point operator +(Point p, int value)
    {
        return new Point(p._x + value, p._y);
    }

    public static Point operator +(int value, Point p)
    {
        return new Point(p._x + value, p._y);
    }

    public override string ToString()
    {
        return "Точка (" + _x  + ";"+ _y+ ")";
    }

}
