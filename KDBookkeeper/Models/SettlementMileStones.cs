using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class SettlementMileStones
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SettlementId { get; set; }
        public int LaternEventId { get; set; }

        public virtual LanternEvent LaternEvent { get; set; }
        public virtual Settlement Settlement { get; set; }
    }
}
