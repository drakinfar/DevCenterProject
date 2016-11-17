using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class SettlementPrinciple
    {
        public int SettlementId { get; set; }
        public int PrincipleId { get; set; }
        public int Id { get; set; }

        public virtual Principle Principle { get; set; }
        public virtual Settlement Settlement { get; set; }
    }
}
