using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.Entities
{
    public class Hydrogen : NaturalResource
    {
        public override bool IsBiotic { get => false; }
        public override bool IsRenewable { get => true; }
        public override string ToString()
        {
            return "Hydrogen";
        }
    }
}
