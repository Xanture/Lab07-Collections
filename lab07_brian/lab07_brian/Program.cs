using System;

namespace lab07_brian
{


    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            Inventory<Product> newInventory = new Inventory<Product>();
            newInventory.Add(product);
        }
    }
}
