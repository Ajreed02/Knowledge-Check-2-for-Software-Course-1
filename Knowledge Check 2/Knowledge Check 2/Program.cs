using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("How many records do you want to add?");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<CatFood>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            var catFood = new CatFood();

            Console.WriteLine("Enter the name of the product:");
            catFood.Name = Console.ReadLine();

            Console.WriteLine("Enter the price:");
            catFood.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity:");
            catFood.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description:");
            catFood.Description = Console.ReadLine();

            Console.WriteLine("Enter if the cat food is for kittens (true/false):");
            catFood.IsKittenFood = bool.Parse(Console.ReadLine());

            recordList.Add(catFood);
        }

        Console.WriteLine("\nThe records you entered are:");
        foreach (var record in recordList)
        {
            Console.WriteLine(record.ToString());
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
    }
}

class CatFood : Product
{
    public bool IsKittenFood { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Kitten Food: {IsKittenFood}";
    }
}
