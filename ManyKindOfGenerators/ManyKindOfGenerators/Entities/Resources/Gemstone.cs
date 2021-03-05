using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.Entities
{
    public class Gemstone : NaturalResource
    {
        public override bool IsBiotic { get => false; }
        public override bool IsRenewable { get => false; }
        public override string ToString()
        {
            return "Gemstone";
        }
    }
}
