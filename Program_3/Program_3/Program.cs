using System;

// Абстрактний клас Видання
abstract class Publication
{
    public string Title { get; set; }
    public string AuthorSurname { get; set; }

    public Publication(string title, string authorSurname)
    {
        Title = title;
        AuthorSurname = authorSurname;
    }

    // Абстрактний метод виводу інформації
    public abstract void ShowInfo();

    // Метод для перевірки, чи є це видання шуканим
    public virtual bool IsMatch(string authorSurname)
    {
        return AuthorSurname.Equals(authorSurname, StringComparison.OrdinalIgnoreCase);
    }
}

// Клас Книга
class Book : Publication
{
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string authorSurname, int year, string publisher)
        : base(title, authorSurname)
    {
        Year = year;
        Publisher = publisher;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Книга: \"{Title}\", Автор: {AuthorSurname}, Рік: {Year}, Видавництво: {Publisher}");
    }
}

// Клас Стаття
class Article : Publication
{
    public string Journal { get; set; }
    public int IssueNumber { get; set; }
    public int Year { get; set; }

    public Article(string title, string authorSurname, string journal, int issueNumber, int year)
        : base(title, authorSurname)
    {
        Journal = journal;
        IssueNumber = issueNumber;
        Year = year;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Стаття: \"{Title}\", Автор: {AuthorSurname}, Журнал: {Journal}, №{IssueNumber}, {Year} рік");
    }
}

// Клас Електронний ресурс
class ElectronicResource : Publication
{
    public string Link { get; set; }
    public string Annotation { get; set; }

    public ElectronicResource(string title, string authorSurname, string link, string annotation)
        : base(title, authorSurname)
    {
        Link = link;
        Annotation = annotation;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Електронний ресурс: \"{Title}\", Автор: {AuthorSurname}, Посилання: {Link}");
        Console.WriteLine($"Анотація: {Annotation}");
    }
}

// Демонстрація роботи
class Program
{
    static void Main()
    {
        // Створення каталогу видань
        Publication[] catalog = new Publication[]
        {
            new Book("Програмування на C#", "Іваненко", 2022, "Наука і Техніка"),
            new Article("Алгоритми шифрування", "Петренко", "Кібербезпека", 3, 2021),
            new ElectronicResource("Онлайн курс C#", "Іваненко", "https://example.com/csharp", "Безкоштовний курс по основам C#"),
            new Book("Математичний аналіз", "Шевченко", 2019, "Університетське видавництво")
        };

        Console.WriteLine("=== УСІ ВИДАННЯ ===\n");
        foreach (var pub in catalog)
        {
            pub.ShowInfo();
            Console.WriteLine();
        }

        Console.Write("Введіть прізвище автора для пошуку: ");
        string searchSurname = Console.ReadLine();

        Console.WriteLine($"\n=== ЗНАЙДЕНІ ВИДАННЯ ДЛЯ АВТОРА \"{searchSurname}\" ===\n");
        bool found = false;
        foreach (var pub in catalog)
        {
            if (pub.IsMatch(searchSurname))
            {
                pub.ShowInfo();
                Console.WriteLine();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Видання не знайдено.");
        }
    }
}
