using System;

class Octopus
{
    // Fields
    public readonly string Name;
    public readonly int Legs = 8;
    public int Age = 13; // Default age

    // Constructor
    public Octopus(string name)
    {
        Name = name;
    }

    // Property
    public string Description
    {
        get { return $"{Name} is {Age} years old and has {Legs} legs."; }
    }

    // Method
    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming!");
    }
}

class Program
{
    static void Main()
    {
        // Create an object and show its data
        Octopus o = new Octopus("Little Lipo");
        Console.WriteLine(o.Description);
        o.Swim();
    }
}
// This code defines an Octopus class with fields, a constructor, a property, and a method.