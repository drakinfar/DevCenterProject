using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class Innovation
    {
        public Innovation()
        {
            GameStartingInnovation = new HashSet<GameStartingInnovation>();
            InnovationModifier = new HashSet<InnovationModifier>();
            InnovationWords = new HashSet<InnovationWords>();
            SettlementInnovation = new HashSet<SettlementInnovation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ParentWord { get; set; }
        public string Expansion { get; set; }

        public virtual ICollection<GameStartingInnovation> GameStartingInnovation { get; set; }
        public virtual ICollection<InnovationModifier> InnovationModifier { get; set; }
        public virtual ICollection<InnovationWords> InnovationWords { get; set; }
        public virtual ICollection<SettlementInnovation> SettlementInnovation { get; set; }
    }
}
