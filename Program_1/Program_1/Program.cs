using System;

// Базовий клас
class Worker
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    public Worker(string name, int age, string position)
    {
        Name = name;
        Age = age;
        Position = position;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Посада: {Position}");
    }
}

// Клас Робітник
class Laborer : Worker
{
    public string Tool { get; set; }

    public Laborer(string name, int age, string tool)
        : base(name, age, "Робітник")
    {
        Tool = tool;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Інструмент: {Tool}");
    }
}

// Клас Кадри
class HR : Worker
{
    public int EmployeeCount { get; set; }

    public HR(string name, int age, int employeeCount)
        : base(name, age, "Кадри")
    {
        EmployeeCount = employeeCount;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Кількість працівників: {EmployeeCount}");
    }
}

// Клас Інженер
class Engineer : Worker
{
    public string Specialization { get; set; }

    public Engineer(string name, int age, string specialization)
        : base(name, age, "Інженер")
    {
        Specialization = specialization;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Спеціалізація: {Specialization}");
    }
}

// Клас Адміністрація
class Administration : Worker
{
    public string Department { get; set; }

    public Administration(string name, int age, string department)
        : base(name, age, "Адміністрація")
    {
        Department = department;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Відділ: {Department}");
    }
}

// Демонстрація
class Program
{
    static void Main()
    {
        Laborer laborer = new Laborer("Іван", 35, "Молоток");
        HR hr = new HR("Олена", 42, 150);
        Engineer engineer = new Engineer("Петро", 29, "Електроніка");
        Administration admin = new Administration("Марія", 50, "Фінансовий");

        laborer.Show();
        Console.WriteLine();
        hr.Show();
        Console.WriteLine();
        engineer.Show();
        Console.WriteLine();
        admin.Show();
    }
}
