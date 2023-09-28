// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("African Land Animals:");
        ILandAnimalFactory africanLandFactory = new AfricanLandAnimalFactory();
        ILandAnimal landAnimalAfrican = africanLandFactory.CreateLandAnimal();
        landAnimalAfrican.Roam();

        Console.WriteLine("\nOcean Sea Animals:");
        ISeaAnimalFactory oceanSeaFactory = new OceanSeaAnimalFactory();
        ISeaAnimal seaAnimalOcean = oceanSeaFactory.CreateSeaAnimal();
        seaAnimalOcean.Swim();
        Console.ReadLine();
    }
}