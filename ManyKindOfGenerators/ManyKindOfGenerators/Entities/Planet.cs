using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.Entities
{
    public class Planet
    {
        public uint Diameter { get; set; }
        public bool IsRoguePlanet { get; set; }
        public bool IsWithinCircumstellarHabitableZone { get; set; }
        public bool IsHellscape { get; set; }
        public bool HasRockMantle { get; set; }
        public bool HasActiveCore { get; set; }

        public bool HasMountains { get; set; }
        public bool HasVolcanoes { get; set; }
        public bool HasOxygen { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Diameter: {Diameter} meters\nIs Rogue Planet: {IsRoguePlanet}\n");
            sb.Append($"Within habitable zone: {IsWithinCircumstellarHabitableZone}\nIs a Hellscape: {IsHellscape}\n");
            sb.Append($"Has rock mantle: {HasRockMantle}\nHas an active core: {HasActiveCore}\n");
            sb.Append($"Has mountains: {HasRockMantle}\nHas volcanoes: {HasVolcanoes}\nHas oxygen: {HasOxygen}\n");

            return sb.ToString();
        }
    }
}
