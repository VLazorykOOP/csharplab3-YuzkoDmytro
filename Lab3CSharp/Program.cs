using System;
using System.Collections.Generic;

class ITriangle
{
    protected int a; // сторона основи
    protected int b; // бічна сторона
    protected int c; // колір трикутника

    public ITriangle(int sideA, int sideB, int color)
    {
        a = sideA;
        b = sideB;
        c = color;
    }

    public int SideA
    {
        get { return a; }
        set { a = value; }
    }

    public int SideB
    {
        get { return b; }
        set { b = value; }
    }

    public int Color
    {
        get { return c; }
    }

    public void DisplayTriangleInfo()
    {
        Console.WriteLine($"Трикутник із сторонами {a}, {b}, колір: {c}");
    }

    public double CalculatePerimeter()
    {
        return a + b + Math.Sqrt(a * a + b * b);
    }

    public double CalculateArea()
    {
        return 0.5 * a * b;
    }

    public bool IsEquilateral()
    {
        return a == b;
    }
}

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}");
    }
}

// Похідний клас для робітника
class Worker : Employee
{
    public string Position { get; set; }

    public Worker(string name, string department, string position) : base(name, department)
    {
        Position = position;
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}, Position: {Position}");
    }
}

// Похідний клас для кадрів
class HR : Employee
{
    public int YearsOfExperience { get; set; }

    public HR(string name, string department, int yearsOfExperience) : base(name, department)
    {
        YearsOfExperience = yearsOfExperience;
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}, Years of Experience: {YearsOfExperience}");
    }
}

// Похідний клас для інженера
class Engineer : Employee
{
    public string Specialization { get; set; }

    public Engineer(string name, string department, string specialization) : base(name, department)
    {
        Specialization = specialization;
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}, Specialization: {Specialization}");
    }
}

// Похідний клас для адміністрації
class Administration : Employee
{
    public string Role { get; set; }

    public Administration(string name, string department, string role) : base(name, department)
    {
        Role = role;
    }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}, Role: {Role}");
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву різних об'єктів
        List<Employee> employees = new List<Employee>
        {
            new Worker("John Doe", "Production", "Technician"),
            new HR("Jane Smith", "HR Department", 5),
            new Engineer("Alex Johnson", "Engineering", "Mechanical Engineer"),
            new Administration("Emily Brown", "Administration", "Manager")
        };

        // Виведення інформації про об'єкти масиву
        Console.WriteLine("Employees:");
        foreach (var employee in employees)
        {
            employee.Show();
        }
        
        ITriangle triangle1 = new ITriangle(3, 4, 1);
        ITriangle triangle2 = new ITriangle(5, 5, 2);

        triangle1.DisplayTriangleInfo();
        Console.WriteLine($"Периметр: {triangle1.CalculatePerimeter()}, Площа: {triangle1.CalculateArea()}, Чи є рівностороннім: {triangle1.IsEquilateral()}");

        triangle2.DisplayTriangleInfo();
        Console.WriteLine($"Периметр: {triangle2.CalculatePerimeter()}, Площа: {triangle2.CalculateArea()}, Чи є рівностороннім: {triangle2.IsEquilateral()}");
    }
}
