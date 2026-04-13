using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


internal class Grades
{
    private int _subject1;
    private int _subject2;
    private int _subject3;

    public Grades()
    {
        _subject1 = 5;
        _subject2 = 5;
        _subject3 = 5;
    }

    public Grades(int Subject1, int Subject2, int Subject3)
    {
        this.Subject1 = Subject1;
        this.Subject2 = Subject2;
        this.Subject3 = Subject3;
    }

    public Grades(Grades grades)
    {
        this.Subject1 = grades.Subject1;
        this.Subject2 = grades.Subject2;
        this.Subject3 = grades.Subject3;
    }

    public int Subject1
    {
        get
        {
            return this._subject1;
        }
        set
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 1 до 5");
            }
            else
            {
                this._subject1 = value;
            }
        }
    }

    public int Subject2
    {
        get
        {
            return this._subject2;
        }
        set
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 1 до 5");
            }
            else
            {
                this._subject2 = value;
            }
        }
    }

    public int Subject3
    {
        get
        {
            return this._subject3;
        }
        set
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 1 до 5");
            }
            else
            {
                this._subject3 = value;
            }
        }
    }

    public int Max()
    {
        int max = Subject1;

        if (Subject2 > max)
            max = Subject2;

        if (Subject3 > max)
            max = Subject3;

        return max;
    }

    public override string ToString()
    {
        return  "Оценка 1: " + Subject1 + " " + "Оценка 2: " + Subject2 + " " + "Оценка 3: " + Subject3;
    }
}
