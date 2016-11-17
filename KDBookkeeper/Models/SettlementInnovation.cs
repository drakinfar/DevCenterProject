using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class SettlementInnovation
    {
        public int SettlementId { get; set; }
        public int InnovatonId { get; set; }
        public int Id { get; set; }

        public virtual Innovation Innovaton { get; set; }
        public virtual Settlement Settlement { get; set; }
    }
}
