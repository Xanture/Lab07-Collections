using System;

namespace lab07_brian
{


    class Program
    {
        static void Main(string[] args)
        {

            Inventory<Product> briansStore = new Inventory<Product>();

            Product yarnBall = new Product("Ball of Yarn", 5);
            yarnBall.IsForCats = true;
            yarnBall.Placement = Department.Pets;

            Product rabbertKleinsBrother = new Product("Lettuce", 2);
            rabbertKleinsBrother.Placement = Department.Produce;

            Product fish = new Product("Salmon", 10);
            fish.IsForCats = true;
            fish.Placement = Department.Meat;

            Product laundrySoap = new Product("Laundry Soap", 4.5);
            laundrySoap.Placement = Department.Cleaning;

            Product batteries = new Product("AAA Batteries", 3.4);
            batteries.Placement = Department.HouseholdGoods;

            Product pop = new Product("Coke", 1.5);
            pop.Placement = Department.Cleaning;

            Product flower = new Product("Flower", 3);
            flower.Placement = Department.Baking;

            Product chocolate = new Product("Baking Chocolate", 3);
            chocolate.Placement = Department.Baking;

            Product sugar = new Product("Sugar", 2.3);
            sugar.Placement = Department.Baking;

            Product laserPointer = new Product("Laser Pointer", 5);
            laserPointer.IsForCats = true;
            laserPointer.Placement = Department.Pets;

            Product human = new Product("Brian", 9000.01);
            human.IsForCats = true;
            human.Placement = Department.Meat;

            briansStore.Add(yarnBall);
            briansStore.Add(rabbertKleinsBrother);
            briansStore.Add(fish);
            briansStore.Add(laundrySoap);
            briansStore.Add(batteries);
            briansStore.Add(pop);
            briansStore.Add(flower);
            briansStore.Add(chocolate);
            briansStore.Add(sugar);
            briansStore.Add(laserPointer);
            briansStore.Add(human);


            foreach (Product p in briansStore)
            {
                Console.Write($"{p.Name} :");
            }
            Console.WriteLine();
            
            briansStore.Remove(pop);

            foreach (Product r in briansStore)
            {
                Console.Write($"{r.Name} :");
            }
            Console.WriteLine();

            fish.CatsMeow();
        }
    }
}
