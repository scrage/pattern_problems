using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.Entities
{
    class Tree : NaturalResource
    {
        public override bool IsBiotic { get => true; }
        public override bool IsRenewable { get => true; }
        public override string ToString()
        {
            return "Tree";
        }
    }
}
