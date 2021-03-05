using ManyKindOfGenerators.Entities;
using System;
using System.Collections.Generic;

namespace ManyKindOfGenerators.Interfaces
{
    public abstract class ResourceGenerator
    {
        protected Random random;
        public abstract List<NaturalResource> GenerateResourcesFor(Planet planet);
    }
}
