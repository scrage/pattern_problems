using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.Entities
{
    public class Carbon : NaturalResource
    {
        public override bool IsBiotic { get => true; }
        public override bool IsRenewable { get => true; }
        public override string ToString()
        {
            return "Carbon";
        }
    }
}
