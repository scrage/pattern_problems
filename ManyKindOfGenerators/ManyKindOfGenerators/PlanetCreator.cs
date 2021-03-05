using ManyKindOfGenerators.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators
{
    public enum PlanetSize : byte
    {
        Tiny,
        Medium,
        Giant
    }

    public static class PlanetCreator
    {
        private static readonly int MinPlanetSize = 2000;
        private static readonly int MaxPlanetSize = 200000;
        private static readonly float ChanceForHellscape = .25f;
        private static readonly float ChanceForRockMantle = .8f;
        private static readonly float ChanceForActiveCore = .75f;
        private static readonly float ChanceForHavingOxygen = .3f;
        private static Random random = new Random();

        public static Planet CreatePlanet(float habitableProbability, PlanetSize size)
        {
            return new Planet()
                .DefineInterstellarDetails(habitableProbability, size)
                .DefineTerrainDetails();
        }

        private static Planet DefineInterstellarDetails(this Planet planet, float habitableProbability, PlanetSize size)
        {
            float randomChance;

            randomChance = (float)random.NextDouble();
            planet.IsWithinCircumstellarHabitableZone = randomChance < habitableProbability;
            
            randomChance = (float)random.NextDouble();
            planet.IsHellscape = !planet.IsWithinCircumstellarHabitableZone || randomChance < ChanceForHellscape;

            switch (size)
            {
                case PlanetSize.Tiny:
                    planet.Diameter = (uint)random.Next(MinPlanetSize, 20000);
                    break;
                case PlanetSize.Medium:
                    planet.Diameter = (uint)random.Next(20001, 60000);
                    break;
                case PlanetSize.Giant:
                    planet.Diameter = (uint)random.Next(60001, MaxPlanetSize);
                    break;
                default:
                    break;
            }

            randomChance = (float)random.NextDouble();
            planet.HasOxygen = randomChance < ChanceForHavingOxygen;

            return planet;
        }

        private static Planet DefineTerrainDetails(this Planet planet)
        {
            float randomChance;

            randomChance = (float)random.NextDouble();
            planet.HasRockMantle = randomChance < ChanceForRockMantle;

            randomChance = (float)random.NextDouble();
            planet.HasActiveCore = randomChance < ChanceForActiveCore;

            planet.HasMountains = planet.HasRockMantle && planet.Diameter > 10000;
            planet.HasVolcanoes = planet.HasMountains && planet.HasActiveCore;

            return planet;
        }
    }
}
