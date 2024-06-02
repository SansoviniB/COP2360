using System;

namespace Octopus
{
    class Octopus
    {
        public readonly int Legs;
        public readonly int Eyes;
        
        public string Species;
        public string Location;
        public string Name;

        // Constructor to initialize the read-only fields and other properties
        public Octopus()
        {
            Legs = 8;
            Eyes = 2;
            Species = "Blue-Ringed";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Octopus octopus1 = new Octopus();

            Console.Write("Enter the octopus's name: ");
            octopus1.Name = Console.ReadLine();

            Console.Write("What ocean do they live in? ");
            octopus1.Location = Console.ReadLine();

            //Break in the console for better readability
            Console.WriteLine();

            // Output using string interpolation
            Console.WriteLine($"{octopus1.Name} the octopus has {octopus1.Eyes} eyes and {octopus1.Legs} legs.");
            Console.WriteLine($"{octopus1.Name} belongs to the {octopus1.Species} Octopus species.");
            Console.WriteLine($"{octopus1.Name} the octopus can be found in the {octopus1.Location} ocean.");
            
            Console.ReadLine();
        }
    }
}