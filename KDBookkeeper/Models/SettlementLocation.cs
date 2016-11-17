using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class SettlementLocation
    {
        public int SettlementId { get; set; }
        public int LocationId { get; set; }
        public int Id { get; set; }

        public virtual Location Location { get; set; }
        public virtual Settlement Settlement { get; set; }
    }
}
