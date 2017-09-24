using System;
using System.Runtime.InteropServices;

namespace lab07_brian
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsForCats { get; set; }
        public Department Placement { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void CatsMeow()
        {
            if (Placement == Department.Meat && Name == "Salmon")
            {
                Console.WriteLine("I want that right Meeeow!");
            }
        }

    }
    enum Department : int
    {
        Meat = 1,
        Produce,
        Cleaning,
        Baking,
        Pets,
        HouseholdGoods
    }
}
