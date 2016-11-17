using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class SettlementResource
    {
        public int SettlementId { get; set; }
        public int ResourceId { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }

        public virtual ResourceItem Resource { get; set; }
        public virtual Settlement Settlement { get; set; }
    }
}
