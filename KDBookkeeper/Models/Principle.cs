using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class Principle
    {
        public Principle()
        {
            PrincipleModifier = new HashSet<PrincipleModifier>();
            SettlementPrinciple = new HashSet<SettlementPrinciple>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PrincipleModifier> PrincipleModifier { get; set; }
        public virtual ICollection<SettlementPrinciple> SettlementPrinciple { get; set; }
    }
}
