using System;

class Worker
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    // Конструктор за замовчуванням
    public Worker()
    {
        Console.WriteLine("Викликано конструктор Worker за замовчуванням.");
    }

    // Конструктор з одним параметром
    public Worker(string name)
    {
        Name = name;
        Console.WriteLine("Викликано конструктор Worker з параметром name.");
    }

    // Повний конструктор
    public Worker(string name, int age, string position)
    {
        Name = name;
        Age = age;
        Position = position;
        Console.WriteLine("Викликано повний конструктор Worker.");
    }

    // Деструктор
    ~Worker()
    {
        Console.WriteLine("Звільнення ресурсів базового класу Worker.");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Посада: {Position}");
    }
}

// Робітник
class Laborer : Worker
{
    public string Tool { get; set; }

    public Laborer() : base()
    {
        Console.WriteLine("Викликано конструктор Laborer за замовчуванням.");
    }

    public Laborer(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор Laborer з параметром name.");
    }

    public Laborer(string name, int age, string tool)
        : base(name, age, "Робітник")
    {
        Tool = tool;
        Console.WriteLine("Викликано повний конструктор Laborer.");
    }

    ~Laborer()
    {
        Console.WriteLine("Звільнення ресурсів Laborer.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Інструмент: {Tool}");
    }
}

// Кадри
class HR : Worker
{
    public int EmployeeCount { get; set; }

    public HR() : base()
    {
        Console.WriteLine("Викликано конструктор HR за замовчуванням.");
    }

    public HR(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор HR з параметром name.");
    }

    public HR(string name, int age, int employeeCount)
        : base(name, age, "Кадри")
    {
        EmployeeCount = employeeCount;
        Console.WriteLine("Викликано повний конструктор HR.");
    }

    ~HR()
    {
        Console.WriteLine("Звільнення ресурсів HR.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Кількість працівників: {EmployeeCount}");
    }
}

// Інженер
class Engineer : Worker
{
    public string Specialization { get; set; }

    public Engineer() : base()
    {
        Console.WriteLine("Викликано конструктор Engineer за замовчуванням.");
    }

    public Engineer(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор Engineer з параметром name.");
    }

    public Engineer(string name, int age, string specialization)
        : base(name, age, "Інженер")
    {
        Specialization = specialization;
        Console.WriteLine("Викликано повний конструктор Engineer.");
    }

    ~Engineer()
    {
        Console.WriteLine("Звільнення ресурсів Engineer.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Спеціалізація: {Specialization}");
    }
}

// Адміністрація
class Administration : Worker
{
    public string Department { get; set; }

    public Administration() : base()
    {
        Console.WriteLine("Викликано конструктор Administration за замовчуванням.");
    }

    public Administration(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор Administration з параметром name.");
    }

    public Administration(string name, int age, string department)
        : base(name, age, "Адміністрація")
    {
        Department = department;
        Console.WriteLine("Викликано повний конструктор Administration.");
    }

    ~Administration()
    {
        Console.WriteLine("Звільнення ресурсів Administration.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Відділ: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Створення об'єктів ===\n");

        Laborer laborer = new Laborer("Іван", 35, "Дриль");
        HR hr = new HR("Олена", 40, 120);
        Engineer eng = new Engineer("Петро", 30, "Автоматизація");
        Administration admin = new Administration("Марія", 45, "Бухгалтерія");

        Console.WriteLine("\n=== Інформація про об'єкти ===\n");
        laborer.Show();
        Console.WriteLine();
        hr.Show();
        Console.WriteLine();
        eng.Show();
        Console.WriteLine();
        admin.Show();

        Console.WriteLine("\n=== Кінець Main ===");
    }
}
