using System;

class Device
{
    public string Name { get; }
    public string Characteristics { get; }

    public Device(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Пристрій видає звук.");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Назва пристрою: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Опис: {Characteristics}");
    }
}

class Kettle : Device
{
    public double Volume { get; }  
    public int Power { get; }    

    public Kettle(string name, double volume, int power)
        : base(name, $"електричний чайник, об'єм {volume} л, потужність {power} Вт")
    {
        Volume = volume;
        Power = power;
    }

    public override void Sound() => Console.WriteLine("Чайник: Шшшш... Біііп! (закипів)");
    public override void Show() => Console.WriteLine($"Чайник: {Name}");
    public override void Desc() => Console.WriteLine($"Чайник — {Characteristics}. Нагріває воду.");
}

class Microwave : Device
{
    public int Power { get; }      
    public int Capacity { get; }   

    public Microwave(string name, int power, int capacity)
        : base(name, $"мікрохвильова піч, потужність {power} Вт, об'єм камери {capacity} л")
    {
        Power = power;
        Capacity = capacity;
    }

    public override void Sound() => Console.WriteLine("Мікрохвильовка: Бззз... Дзинь! (їжа розігріта)");
    public override void Show() => Console.WriteLine($"Мікрохвильовка: {Name}");
    public override void Desc() => Console.WriteLine($"Мікрохвильовка — {Characteristics}. Розігріває їжу.");
}

class Car : Device
{
    public string Engine { get; }
    public int MaxSpeed { get; }   

    public Car(string name, string engine, int maxSpeed)
        : base(name, $"автомобіль, двигун {engine}, максимальна швидкість {maxSpeed} км/год")
    {
        Engine = engine;
        MaxSpeed = maxSpeed;
    }

    public override void Sound() => Console.WriteLine("Автомобіль: Вррр-вррр! Бііп-біп!");
    public override void Show() => Console.WriteLine($"Автомобіль: {Name}");
    public override void Desc() => Console.WriteLine($"Автомобіль — {Characteristics}. Перевозить пасажирів по дорогах.");
}

class Steamship : Device
{
    public int Length { get; }      
    public int Passengers { get; }

    public Steamship(string name, int length, int passengers)
        : base(name, $"пароплав, довжина {length} м, пасажиромісткість {passengers} осіб")
    {
        Length = length;
        Passengers = passengers;
    }

    public override void Sound() => Console.WriteLine("Пароплав: Ту-у-у-у! (гудок)");
    public override void Show() => Console.WriteLine($"Пароплав: {Name}");
    public override void Desc() => Console.WriteLine($"Пароплав — {Characteristics}. Плаває по воді.");
}

class Program
{
    static void Main()
    {
        Device[] devices =
        {
            new Kettle("Philips HD9350", 1.7, 2200),
            new Microwave("Samsung MS23", 800, 23),
            new Car("Toyota Camry", "2.5 л бензиновий", 210),
            new Steamship("Адмірал", 120, 450)
        };

        foreach (Device d in devices)
        {
            d.Show();
            d.Desc();
            d.Sound();
            Console.WriteLine();
        }
    }
}