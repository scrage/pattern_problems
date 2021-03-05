using ManyKindOfGenerators.Entities;
using ManyKindOfGenerators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.ResourceGenerators
{
    public class EnergyResourceGenerator : ResourceGenerator
    {
        public override List<NaturalResource> GenerateResourcesFor(Planet planet)
        {
            var naturalResources = new List<NaturalResource>();

            if (!planet.IsRoguePlanet)
            {
                naturalResources.Add(new SolarEnergy() { Occurrence = Occurrence.Abundant, StageOfDevelopment = StageOfDevelopment.Stock });
            }

            if (planet.HasActiveCore)
            {
                naturalResources.Add(new ThermalEnergy() { Occurrence = Occurrence.Rare, StageOfDevelopment = StageOfDevelopment.Stock });
            }

            return naturalResources;
        }
    }
}
