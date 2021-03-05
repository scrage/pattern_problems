using ManyKindOfGenerators.Entities;
using ManyKindOfGenerators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.ResourceGenerators
{
    public class GeologicResourceGenerator : ResourceGenerator
    {
        public override List<NaturalResource> GenerateResourcesFor(Planet planet)
        {
            var naturalResources = new List<NaturalResource>();

            if (planet.HasRockMantle)
            {
                naturalResources.Add(new Gemstone() { Occurrence = Occurrence.ExtremelyRare, StageOfDevelopment = StageOfDevelopment.Potential });
                naturalResources.Add(new Mineral() { Occurrence = Occurrence.Rare, StageOfDevelopment = StageOfDevelopment.Stock });
            }

            if (planet.HasVolcanoes)
            {
                naturalResources.Add(new Basalt() { Occurrence = Occurrence.Rare, StageOfDevelopment = StageOfDevelopment.Potential });
            }

            return naturalResources;
        }
    }
}
