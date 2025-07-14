
using System;

public class Octopus
{
    public readonly string Name;
    public readonly int Legs = 8;

    public Octopus(string name)
    {
        Name = name;
    }

    //  Nested class to describe the Octopus
    public class Info
    {
        public static void Describe(Octopus o)
        {
            Console.WriteLine($"This octopus is named {o.Name} and has {o.Legs} legs.");
        }
    }
}

class Program
{
    static void Main()
    {
        Octopus myOctopus = new Octopus("Jack");

        //  Call the nested class method
        Octopus.Info.Describe(myOctopus);
    }
}
