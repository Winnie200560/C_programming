using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите данные студента");

        string name;
        string surname;

        Console.Write("Имя: ");
        name = Console.ReadLine();

        Console.Write("Фамилия: ");
        surname = Console.ReadLine();

        int s1, s2, s3;
        Console.Write("Оценка 1: ");
        while (!int.TryParse(Console.ReadLine(), out s1))
        {
            Console.Write("Ошибка! Введите число в диапазоне от 1 д о 5: ");
        }
        
        Console.Write("Оценка 2: ");
        while (!int.TryParse(Console.ReadLine(), out s2))
        {
            Console.Write("Ошибка! Введите число в диапазоне от 1 д о 5: ");
        }

        Console.Write("Оценка 3: ");
        while (!int.TryParse(Console.ReadLine(), out s3))
        {
            Console.Write("Ошибка! Введите число в диапазоне от 1 д о 5: ");
        }
        //Console.Write("Оценка 3: ");
        //s3 = int.Parse(Console.ReadLine());

        Student student = new Student(name, surname, s1, s2, s3);

        Console.WriteLine();
        Console.WriteLine(student.ToString());

        Console.WriteLine("Средний балл: " + student.Average());
        Console.WriteLine("Максимальная оценка: " + student.Max());
        Console.WriteLine("Стипендия: " + student.HasScholarship());
        Console.WriteLine();
    }
}