using System;

// Базовий клас Робітник
public class Worker
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public bool IsFired { get; set; }

    // Конструктор
    public Worker(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
        IsFired = false; // За замовчуванням працівник не звільнений
    }

    // Метод для звільнення працівників
    public virtual void Fire()
    {
        IsFired = true;
        Console.WriteLine($"Працiвник {Name} звiльнений.");
    }

    // Метод для підвищення зарплати
    public virtual void IncreaseSalary(double amount)
    {
        Salary += amount;
        Console.WriteLine($"Зарплата працівника {Name} пiдвищена на {amount}.");
    }

    // Перевизначення методу Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Worker other = (Worker)obj;
        return Name == other.Name && Salary == other.Salary && Position == other.Position;
    }

    // Перевизначення методу GetHashCode
    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Salary.GetHashCode() ^ Position.GetHashCode();
    }

    // Перевизначення методу ToString
    public override string ToString()
    {
        string status = IsFired ? "Звiльнений" : "На посадi";
        return $"{Position}: {Name}, Зарплата: {Salary}, Статус: {status}";
    }
}

// Клас Менеджер, наслідується від Робітника
public class Manager : Worker
{
    // Конструктор
    public Manager(string name, double salary) : base(name, salary, "Менеджер") { }

    // Перевизначення методу звільнення
    public override void Fire()
    {
        base.Fire(); // Викликаємо базовий метод
        Console.WriteLine("Звiльнення менеджера...");
    }

    // Перевизначення методу підвищення зарплати
    public override void IncreaseSalary(double amount)
    {
        base.IncreaseSalary(amount); // Викликаємо базовий метод
        Console.WriteLine("Пiдвищення зарплати менеджера...");
    }
}

// Клас Інженер, наслідується від Робітника
public class Engineer : Worker
{
    // Конструктор
    public Engineer(string name, double salary) : base(name, salary, "Iнженер") { }

    // Перевизначення методу звільнення
    public override void Fire()
    {
        base.Fire(); // Викликаємо базовий метод
        Console.WriteLine("Звiльнення iнженера...");
    }

    // Перевизначення методу підвищення зарплати
    public override void IncreaseSalary(double amount)
    {
        base.IncreaseSalary(amount); // Викликаємо базовий метод
        Console.WriteLine("Пiдвищення зарплати iнженера...");
    }
}

// Клас Стажист, наслідується від Робітника
public class Intern : Worker
{
    // Конструктор
    public Intern(string name, double salary) : base(name, salary, "Стажист") { }

    // Перевизначення методу звільнення
    public override void Fire()
    {
        base.Fire(); // Викликаємо базовий метод
        Console.WriteLine("Звiльнення стажиста...");
    }

    // Перевизначення методу підвищення зарплати (стажисти не підвищують зарплату)
    public override void IncreaseSalary(double amount)
    {
        Console.WriteLine("Стажистам не пiдвищують зарплату!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання
        Manager manager = new Manager("Iван", 7000);
        Engineer engineer = new Engineer("Петро", 6000);
        Intern intern = new Intern("Марiя", 2000);

        manager.IncreaseSalary(1000);
        engineer.Fire();
        intern.IncreaseSalary(500);

        Console.WriteLine(manager);
        Console.WriteLine(engineer);
        Console.WriteLine(intern);
    }
}
