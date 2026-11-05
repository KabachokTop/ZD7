using System;
using System.Collections.Generic;

abstract class Product
{
    public string Name { get; }
    public decimal Price { get; }

    protected Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public abstract decimal CalculateDiscount();
}

class Electronics : Product
{
    public Electronics(string name, decimal price) : base(name, price) { }

    public override decimal CalculateDiscount()
    {
        return Price * 0.10m;
    }
}

class Furniture : Product
{
    public Furniture(string name, decimal price) : base(name, price) { }

    public override decimal CalculateDiscount()
    {
        return Price >= 10000 ? Price * 0.20m : Price * 0.05m;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics("Ноутбук", 30000m),
            new Electronics("Навушники", 2000m),
            new Furniture("Диван", 15000m),
            new Furniture("Стілець", 1500m)
        };

        foreach (Product p in products)
        {
            decimal discount = p.CalculateDiscount();
            Console.WriteLine($"{p.Name}: ціна {p.Price} грн, знижка {discount} грн, до сплати {p.Price - discount} грн");
        }
    }
}