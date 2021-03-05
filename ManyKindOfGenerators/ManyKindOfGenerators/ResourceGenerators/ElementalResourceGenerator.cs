using ManyKindOfGenerators.Entities;
using ManyKindOfGenerators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.ResourceGenerators
{
    public class ElementalResourceGenerator : ResourceGenerator
    {
        public override List<NaturalResource> GenerateResourcesFor(Planet planet)
        {
            var naturalResources = new List<NaturalResource>();

            if (planet.HasOxygen)
            {
                naturalResources.Add(new Oxygen() { Occurrence = Occurrence.Abundant, StageOfDevelopment = StageOfDevelopment.Stock });
            }

            var randomChance = (float)new Random().NextDouble();
            var hasHydrogen = randomChance < .85f;

            if (hasHydrogen)
            {
                naturalResources.Add(new Hydrogen() { Occurrence = Occurrence.Abundant, StageOfDevelopment = StageOfDevelopment.Stock });
            }

            if (planet.HasOxygen && hasHydrogen)
            {
                naturalResources.Add(new Water() { Occurrence = Occurrence.Occasional, StageOfDevelopment = StageOfDevelopment.Actual });
            }

            return naturalResources;
        }
    }
}
