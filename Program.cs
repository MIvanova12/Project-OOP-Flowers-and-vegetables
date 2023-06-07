using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlower[] flowers = new IFlower[]
       {
            new Rose(),
            new Lily()
       };

            IVegetable[] vegetables = new IVegetable[]
            {
            new Carrot(),
            new Tomato()
            };

            // Step 4: Display Plant Information
            Console.WriteLine("Flowers:");
            foreach (IFlower flower in flowers)
            {
                Console.WriteLine($"Flower: {flower.Name}");
                Console.WriteLine($"Color: {flower.Color}");
                Console.WriteLine($"Bloom Time: {flower.BloomTime}");
                Console.WriteLine();
            }

            Console.WriteLine("Vegetables:");
            foreach (IVegetable vegetable in vegetables)
            {
                Console.WriteLine($"Vegetable: {vegetable.Name}");
                Console.WriteLine($"Color: {vegetable.Color}");
                Console.WriteLine($"Harvest Time: {vegetable.HarvestTime}");
                Console.WriteLine();
            }
        }
    }
    }
