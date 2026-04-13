using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Student : Grades
{
    private string name;
    private string surname;

    // конструктор
    public Student(string name, string surname, int s1, int s2, int s3)
        : base(s1, s2, s3)
    {
        this.Name = name;      
        this.Surname = surname;
    }

    // конструктор копирования
    public Student(Student other)
        : base(other)
    {
        this.Name = other.Name;      
        this.Surname = other.Surname;
    }

    // свойства с проверкой
    public string Name
    {
        get 
        { 
            return name; 
        }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Имя не может быть пустым");
            }
            else
            {
                name = value;
            }
        }
    }

    public string Surname
    {
        get 
        { 
            return surname; 
        }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Фамилия не может быть пустая");
            }
            else
            {
                surname = value;
            }
        }
    }

    // метод, высчитывающий средний балл
    public double Average()
    {
        return (Subject1 + Subject2 + Subject3) / 3.0;
    }

    // метод - стипендия (true/false)
    public bool HasScholarship()
    {
        return Average() >= 4.5;
    }

    public override string ToString()
    {
        return "Студент: " + Name + " " + Surname + "\n" + base.ToString();
    }
}

