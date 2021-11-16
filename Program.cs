using System;
using System.IO;

namespace veggies_and_fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitpath = @"C:\Users\opilane\samples\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitpath);
            string veggiepath = @"C:\Users\opilane\samples\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiepath);

            File.WriteAllLines(fruitpath, fruitData);
            File.WriteAllLines(veggiepath, veggieData);
        }
    }
}
