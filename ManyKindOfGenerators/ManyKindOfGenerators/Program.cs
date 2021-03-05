using System;
using System.Collections.Generic;
using System.IO;
using ManyKindOfGenerators.Entities;
using ManyKindOfGenerators.ResourceGenerators;

namespace ManyKindOfGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            var bioticGenerator = new BioticResourceGenerator();
            var geologicGenerator = new GeologicResourceGenerator();
            var elementalGenerator = new ElementalResourceGenerator();
            var energyGenerator = new EnergyResourceGenerator();

            var planet1 = PlanetCreator.CreatePlanet(.5f, PlanetSize.Tiny);
            var planet2 = PlanetCreator.CreatePlanet(.5f, PlanetSize.Medium);
            var planet3 = PlanetCreator.CreatePlanet(.5f, PlanetSize.Giant);

            var resources1 = new List<NaturalResource>();
            resources1.AddRange(bioticGenerator.GenerateResourcesFor(planet1));
            resources1.AddRange(geologicGenerator.GenerateResourcesFor(planet1));
            resources1.AddRange(elementalGenerator.GenerateResourcesFor(planet1));
            resources1.AddRange(energyGenerator.GenerateResourcesFor(planet1));

            var resources2 = new List<NaturalResource>();
            resources2.AddRange(bioticGenerator.GenerateResourcesFor(planet2));
            resources2.AddRange(geologicGenerator.GenerateResourcesFor(planet2));
            resources2.AddRange(elementalGenerator.GenerateResourcesFor(planet2));
            resources2.AddRange(energyGenerator.GenerateResourcesFor(planet2));

            var resources3 = new List<NaturalResource>();
            resources3.AddRange(bioticGenerator.GenerateResourcesFor(planet3));
            resources3.AddRange(geologicGenerator.GenerateResourcesFor(planet3));
            resources3.AddRange(elementalGenerator.GenerateResourcesFor(planet3));
            resources3.AddRange(energyGenerator.GenerateResourcesFor(planet3));


            PrintResult(planet1, resources1);
            PrintResult(planet2, resources2);
            PrintResult(planet3, resources3);

            Console.ReadKey();
        }

        private static void PrintResult(Planet planet, List<NaturalResource> resources)
        {
            Console.WriteLine(planet);
            Console.WriteLine("Planet's natural resources: ");
            foreach (var resource in resources)
            {
                Console.WriteLine($"\t{resource}");
            }
            Console.WriteLine();

            using (StreamWriter file = new StreamWriter("output.txt", append: true))
            {
                file.WriteLine(planet);
                file.WriteLine("Planet's natural resources: ");
                foreach (var resource in resources)
                {
                    file.WriteLine($"\t{resource}");
                }
                file.WriteLine();
            }
        }
    }
}
