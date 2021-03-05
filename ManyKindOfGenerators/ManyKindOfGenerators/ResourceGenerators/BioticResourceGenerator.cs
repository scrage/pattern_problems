using ManyKindOfGenerators.Entities;
using ManyKindOfGenerators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators
{
    public class BioticResourceGenerator : ResourceGenerator
    {
        public override List<NaturalResource> GenerateResourcesFor(Planet planet)
        {
            var naturalResources = new List<NaturalResource> ();

            if (planet.IsWithinCircumstellarHabitableZone && !planet.IsHellscape && planet.HasOxygen)
            {
                naturalResources.Add(new Tree() { Occurrence = Occurrence.Frequent, StageOfDevelopment = StageOfDevelopment.Actual});
                naturalResources.Add(new Peat() { Occurrence = Occurrence.Occasional, StageOfDevelopment = StageOfDevelopment.Actual});
                naturalResources.Add(new Carbon() { Occurrence = Occurrence.Abundant, StageOfDevelopment = StageOfDevelopment.Reserve});
            }

            return naturalResources;
        }
    }
}
