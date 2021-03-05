using System;
using System.Collections.Generic;
using System.Text;

namespace ManyKindOfGenerators.Entities
{
    public enum StageOfDevelopment : byte
    {
        Potential,
        Actual,
        Reserve,
        Stock
    }

    public enum Occurrence : byte
    {
        ExtremelyRare,
        Rare,
        Occasional,
        Frequent,
        Abundant
    }

    public abstract class NaturalResource
    {
        public virtual bool IsBiotic { get; set; }
        public virtual bool IsRenewable { get; set; }
        public StageOfDevelopment StageOfDevelopment { get; set; }
        public Occurrence Occurrence { get; set; }
    }
}
