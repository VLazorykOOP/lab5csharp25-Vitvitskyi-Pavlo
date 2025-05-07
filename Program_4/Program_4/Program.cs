using System;
using System.Collections.Generic;

struct CountryStruct
{
    public string Name;
    public string Capital;
    public int Population;
    public double Area;

    public CountryStruct(string name, string capital, int population, double area)
    {
        Name = name;
        Capital = capital;
        Population = population;
        Area = area;
    }

    public void Show()
    {
        Console.WriteLine($"{Name} | Столиця: {Capital} | Населення: {Population} | Площа: {Area} км²");
    }
}

public record CountryRecord(string Name, string Capital, int Population, double Area);

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== МЕНЮ ===");
            Console.WriteLine("1. Працювати зі структурами");
            Console.WriteLine("2. Працювати з кортежами");
            Console.WriteLine("3. Працювати із записами (record)");
            Console.WriteLine("0. Вийти");

            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WorkWithStruct();
                    break;
                case "2":
                    WorkWithTuple();
                    break;
                case "3":
                    WorkWithRecord();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }
        }
    }

    static void WorkWithStruct()
    {
        List<CountryStruct> countries = new()
        {
            new CountryStruct("Україна", "Київ", 40000000, 603628),
            new CountryStruct("Німеччина", "Берлін", 83000000, 357022),
            new CountryStruct("Польща", "Варшава", 38000000, 312696),
            new CountryStruct("Словаччина", "Братислава", 5400000, 49035)
        };

        UpdateCountries(countries);
    }

    static void WorkWithTuple()
    {
        List<(string Name, string Capital, int Population, double Area)> countries = new()
        {
            ("Україна", "Київ", 40000000, 603628),
            ("Німеччина", "Берлін", 83000000, 357022),
            ("Польща", "Варшава", 38000000, 312696),
            ("Словаччина", "Братислава", 5400000, 49035)
        };

        Console.Write("Введіть мінімальну чисельність населення: ");
        int minPop = int.Parse(Console.ReadLine());
        countries.RemoveAll(c => c.Population < minPop);

        Console.Write("Введіть індекс після якого додати нову державу: ");
        int index = int.Parse(Console.ReadLine());

        var newCountry = CreateCountryTuple();
        if (index >= 0 && index < countries.Count)
            countries.Insert(index + 1, newCountry);
        else
            countries.Add(newCountry);

        Console.WriteLine("\nСписок країн:");
        foreach (var c in countries)
            Console.WriteLine($"{c.Name} | Столиця: {c.Capital} | Населення: {c.Population} | Площа: {c.Area} км²");
    }

    static void WorkWithRecord()
    {
        List<CountryRecord> countries = new()
        {
            new CountryRecord("Україна", "Київ", 40000000, 603628),
            new CountryRecord("Німеччина", "Берлін", 83000000, 357022),
            new CountryRecord("Польща", "Варшава", 38000000, 312696),
            new CountryRecord("Словаччина", "Братислава", 5400000, 49035)
        };

        Console.Write("Введіть мінімальну чисельність населення: ");
        int minPop = int.Parse(Console.ReadLine());
        countries.RemoveAll(c => c.Population < minPop);

        Console.Write("Введіть індекс після якого додати нову державу: ");
        int index = int.Parse(Console.ReadLine());

        var newCountry = CreateCountryRecord();
        if (index >= 0 && index < countries.Count)
            countries.Insert(index + 1, newCountry);
        else
            countries.Add(newCountry);

        Console.WriteLine("\nСписок країн:");
        foreach (var c in countries)
            Console.WriteLine($"{c.Name} | Столиця: {c.Capital} | Населення: {c.Population} | Площа: {c.Area} км²");
    }

    static void UpdateCountries(List<CountryStruct> countries)
    {
        Console.Write("Введіть мінімальну чисельність населення: ");
        int minPop = int.Parse(Console.ReadLine());
        countries.RemoveAll(c => c.Population < minPop);

        Console.Write("Введіть індекс після якого додати нову державу: ");
        int index = int.Parse(Console.ReadLine());

        var newCountry = CreateCountryStruct();
        if (index >= 0 && index < countries.Count)
            countries.Insert(index + 1, newCountry);
        else
            countries.Add(newCountry);

        Console.WriteLine("\nСписок країн:");
        foreach (var c in countries)
            c.Show();
    }

    static CountryStruct CreateCountryStruct()
    {
        Console.Write("Назва: ");
        string name = Console.ReadLine();
        Console.Write("Столиця: ");
        string capital = Console.ReadLine();
        Console.Write("Населення: ");
        int population = int.Parse(Console.ReadLine());
        Console.Write("Площа: ");
        double area = double.Parse(Console.ReadLine());
        return new CountryStruct(name, capital, population, area);
    }

    static (string, string, int, double) CreateCountryTuple()
    {
        Console.Write("Назва: ");
        string name = Console.ReadLine();
        Console.Write("Столиця: ");
        string capital = Console.ReadLine();
        Console.Write("Населення: ");
        int population = int.Parse(Console.ReadLine());
        Console.Write("Площа: ");
        double area = double.Parse(Console.ReadLine());
        return (name, capital, population, area);
    }

    static CountryRecord CreateCountryRecord()
    {
        Console.Write("Назва: ");
        string name = Console.ReadLine();
        Console.Write("Столиця: ");
        string capital = Console.ReadLine();
        Console.Write("Населення: ");
        int population = int.Parse(Console.ReadLine());
        Console.Write("Площа: ");
        double area = double.Parse(Console.ReadLine());
        return new CountryRecord(name, capital, population, area);
    }
}
