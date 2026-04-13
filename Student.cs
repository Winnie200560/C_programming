using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Student : Grades
{
    private string _name;
    private string _surname;

    public Student()
    : base()
    {
        Name = "Неизвестно";
        Surname = "Неизвестно";
    }

    public Student(string name, string surname, int s1, int s2, int s3)
        : base(s1, s2, s3)
    {
        this.Name = name;      
        this.Surname = surname;
    }

    public Student(Student other)
        : base(other)
    {
        this.Name = other.Name;      
        this.Surname = other.Surname;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Имя не может быть пустым!");
            }
            else
            {
                _name = value;
            }
        }
    }

    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Фамилия не может быть пустая!");
            }
            else
            {
                _surname = value;
            }
        }
    }
 
    public double Average()
    {
        return (Subject1 + Subject2 + Subject3) / 3.0;
    }

    public bool HasScholarship()
    {
        return Average() >= 4.5;
    }

    public override string ToString()
    {
        return "Студент: " + Name + " " + Surname + "\n" + base.ToString();
    }
}

