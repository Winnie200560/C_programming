using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


internal class Grades
{
    private int subject1;
    private int subject2;
    private int subject3;

    // конструктор
    public Grades(int Subject1, int Subject2, int Subject3)
    {
        this.Subject1 = Subject1;
        this.Subject2 = Subject2;
        this.Subject3 = Subject3;
    }

    // констркутор копирования
    public Grades(Grades grades)
    {
        this.Subject1 = grades.Subject1;
        this.Subject2 = grades.Subject2;
        this.Subject3 = grades.Subject3;
    }

    // свойства
    public int Subject1
    {
        get 
        { 
            return this.subject1; 
        }
        set
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 1 до 5");
            }
            else
            {
                this.subject1 = value;
            }
        }
    }

    public int Subject2
    {
        get 
        { 
            return this.subject2; 
        }
        set
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 1 до 5");
            }
            else
            {
                this.subject2 = value;
            }
        }
    }

    public int Subject3
    {
        get 
        { 
            return this.subject3; 
        }
        set
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 1 до 5");
            }
            else
            {
                this.subject3 = value;
            }
        }
    }

    // метод, вычисляющий максимально из полей
    public int Max()
    {
        int max = Subject1;

        if (Subject2 > max)
            max = Subject2;

        if (Subject3 > max)
            max = Subject3;

        return max;
    }

    // перегрузка метода ToString
    public override string ToString()
    {
        return  "Оценка 1: " + Subject1 + " " + "Оценка 2: " + Subject2 + " " + "Оценка 3: " + Subject3;
    }
}
